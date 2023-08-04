using System;
					
public class RsboPatt
{
	public static void Main()
	{
		
		var sub = new Subject();
		new Observer(sub);
		new Observer2(sub);
		new Observer3(sub);
		// obs.Receiver(sub);
		
		// sub.SomeEvent
		sub.Notify("6");
		Console.WriteLine("Hello World" + null + " check");
	}
}

   public class Subject
   {
      public delegate void EventHandler(string message);

      public event EventHandler SomeEvent;

      public void Notify(string callNo)
      {
		  SomeEvent?.Invoke($"Call {callNo} from subject.");
      }

   }

   public class Observer
   {
      public Observer(Subject subject)
      {
         subject.SomeEvent += Update;
      }

      public void Update(string message_)
      {
         Console.WriteLine($"{typeof(Observer)} - Received {message_} from {typeof(Subject)} .");
      }
   }

   public class Observer2
   {
      public Observer2(Subject subject)
      {
         subject.SomeEvent += Update;
      }

      public void Update(string message_)
      {
         Console.WriteLine($"{typeof(Observer2)} - Received {message_} from {typeof(Subject)} .");
      }
   }

   public class Observer3
   {
      public Observer3(Subject subject)
      {
         subject.SomeEvent += Update;
      }

      public void Update(string message_)
      {
         Console.WriteLine($"{typeof(Observer3)} - Received {message_} from {typeof(Subject)} .");
      }
   }
