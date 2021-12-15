using System;
using static System.Console;

namespace DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomthingHappend(string message)
        {
            WriteLine($"{name}.SomthingHappend : {message}");
        }

    }

    class MainApp
    {
        static void Main2(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomthingHappend;
            notifier.EventOccured += listener2.SomthingHappend;
            notifier.EventOccured += listener3.SomthingHappend;
            notifier.EventOccured("You've got mail. ");

            WriteLine();

            notifier.EventOccured -= listener2.SomthingHappend;
            notifier.EventOccured("Download complete. ");

            WriteLine();

            notifier.EventOccured = new Notify(listener2.SomthingHappend) + new Notify(listener3.SomthingHappend);
            notifier.EventOccured("Nuclear launch detected. ");

            WriteLine();

            Notify notify1 = new Notify(listener1.SomthingHappend);
            Notify notify2 = new Notify(listener2.SomthingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!!!  ");

            WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!!!  ");
        }
    }
}
