namespace Csharp
{
   using System.Collections.Concurrent;

    public static class Program
   {
      /// <summary>
      /// PE for the single LL.
      /// </summary>
      public static async Task Main(string[] args)
      {
         Entity_ entity_ = new Entity_(new Entity(){ value = 06 });
         entity_.AddLast(10);
         entity_.AddLast(60);
         entity_.AddFirst(3);
         entity_.AddLast(1);
         entity_.AddAfter(6, 12);
         entity_.AddBefore(6, 8);
         // Console.WriteLine(entity_.value);
         entity_.Display();
         // entity_.Display();
      }
    }

      record Entity
      {
         public int value;
         public Entity next;

      }

      class Entity_
      {
         private Entity _entity;

         private Entity _firstEntity;

         private Entity _lastEntity;

         public Entity_(Entity entity)
         {
            _entity = entity;
            _firstEntity = entity;
         }

         public bool AddLast(int ele)
         {
            var entity = _entity;
            while(entity.next != null)
            {
               entity = entity.next;   
            }
 
            entity.next = new Entity() { value = ele, next = null };

            _lastEntity = entity;

            return true;
         }

         public bool AddFirst(int ele)
         {
            var entity = new Entity(){ value = ele, next = _entity };
            _entity = entity;
            return true;
         }

         public int First()
         {
            return _entity.value;
         }

         public int Last()
         {
            return _lastEntity.value;
         }

         public void Display()
         {
            Console.WriteLine("Elements are - ");

            var entity = _entity;

            do {
               Console.Write(entity.value + " ");
               // entity.next.value = entity.value;
               entity = entity.next;   
            }
            while(entity != null);
         }

         // add after ele the value value_
         public bool AddAfter(int ele, int value_)
         {
            var entity = _entity;

            // find the ele
            while(entity.value != ele)
            {
               entity = entity.next;   
            }

            if(entity.value == ele)
            {

               Entity newEntity = new Entity() { value = value_, next = entity.next };
               entity.next = newEntity;
               // _entity = entity;

            }
            else
            {
               Console.WriteLine(ele + " not found!");
            }

            return true;
         }

         // add before ele the value value_
         public bool AddBefore(int ele, int value_)
         {
            var entity = _entity;
            var last = entity;

            // find the ele
            while(entity.value != ele)
            {
               last = entity;
               entity = entity.next;   
            }

            if(entity.value == ele)
            {
               Entity newEntity = new Entity() { value = value_, next = entity };
               last.next = newEntity;
            }
            else
            {
               Console.WriteLine(ele + " not found!");
            }

            return true;
         }

         public Entity_ MoveIndexNext()
         {
            var entity_ = _entity;
            if(entity_.next != null)
            {
               entity_ = entity_.next;
            }

            return new Entity_(entity_);
         }


      }

}
