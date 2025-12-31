using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_03_Task_2.Task_2
{
    public class Memento
    {
        public string State { get; private set; }
        public Memento(string state)
        {
            this.State = state;
        }
    }

    public class History
    {
        private readonly Stack<Memento> _undoStack = new();
        private readonly Stack<Memento> _redoStack = new();

        public void BackUp(Message message)
        {
            _undoStack.Push(message.Save());
            _redoStack.Clear();
        }

        public bool Undo(Message message)
        {
            if (_undoStack.Count == 0)
            {
                return false;
            }

            var current = message.Save();
            _redoStack.Push(current);

            var previous = _undoStack.Pop();
            message.Restore(previous);

            return true;
        }

        public bool Redo(Message message)
        {
            if (_redoStack.Count == 0)
            {
                return false;
            }
            var current = message.Save();
            _undoStack.Push(current);

            var next = _redoStack.Pop();
            message.Restore(next);
            return true;
        }
    }
    public class Message
    {
        public string Text { get; set; } = "";

        public void Restore(Memento memento)
        {
            Text = memento.State;
        }

        public Memento Save()
        {
            return new Memento(Text);
        }
    }

}
