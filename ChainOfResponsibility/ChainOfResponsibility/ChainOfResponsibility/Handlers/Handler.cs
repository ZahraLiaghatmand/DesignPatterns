namespace ChainOfResponsibility.Handlers
{
    public abstract class Handler
    {
        protected Handler _nextHandler;

        public void SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        protected abstract bool ProcessRequest(string request);

        public void HandleRequest(string request)
        {
            if (!ProcessRequest(request) && _nextHandler != null)
                _nextHandler.HandleRequest(request);
        }

    }
}
