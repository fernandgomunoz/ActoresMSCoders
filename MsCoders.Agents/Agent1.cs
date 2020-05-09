using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MsCoders.Agents
{
    public class Agent1
    {
        public Queue<Message> Input { get; set; }

        public Agent1()
        {
            Input = new Queue<Message>();
        }

        public async Task Run()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if (Input.Count > 0)
                    {
                        var msg = Input.Dequeue();
                        if (msg != null)
                        {
                            //Process message
                            msg.Price = msg.Count * msg.Incremt;
                            Console.WriteLine($"{msg.Text} => {msg.Price}");
                        }                    
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }

                   
                }
            });
        }
    }
}
