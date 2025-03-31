namespace Task4
{
    public abstract class Observer
    {
        protected Observer(Subject subject) 
        { 
            _subject = subject;
            _subject.NotifyObservers += Update;
        }
        protected Subject _subject;
        public abstract void Update();
    }
}