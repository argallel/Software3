namespace Assi3 {
    public class IState {

        protected FormComponent _fc;

        public IState(FormComponent fc)
        {
            _fc = fc;
        }

        public virtual void Run() { } // called on creation
    }
}
