namespace Assi3 {
    public class IState {

        protected Form _form;

        public IState(Form form)
        {
            _form = form;
        }

        public virtual void Run(Form form) { } // called on creation
    }
}
