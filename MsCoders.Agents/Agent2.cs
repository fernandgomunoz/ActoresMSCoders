using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MsCoders.Agents
{
    public class Agent2
    {
        public Queue<Message> Input { get; set; }
        public Agent2()
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

                            Console.WriteLine(msg.Text);
                        }
                    }
                    {
                        Thread.Sleep(1000);
                    }

                }
            });
        }
    }
}
