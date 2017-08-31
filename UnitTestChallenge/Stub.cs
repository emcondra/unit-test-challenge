using System;
using System.Linq.Expressions;
using Moq.Language;
using Moq.Language.Flow;

// ReSharper disable once CheckNamespace
namespace Moq
{
    public class Stub<T> : IMock<T> where T : class
    {
        private readonly Mock<T> _stub;

        public Stub()
        {
            _stub = new Mock<T>();
        }

        public Stub(MockBehavior behavior)
        {
            _stub = new Mock<T>(behavior);
        }

        public Stub(params object[] args)
        {
            _stub = new Mock<T>(args);
        }

        public Stub(MockBehavior behavior, params object[] args)
        {
            _stub = new Mock<T>(behavior, args);
        }

        public T Object => _stub.Object;

        public MockBehavior Behavior => _stub.Behavior;

        public bool CallBase
        {
            get { return _stub.CallBase; }
            set { _stub.CallBase = value; }
        }

        public DefaultValue DefaultValue
        {
            get { return _stub.DefaultValue; }
            set { _stub.DefaultValue = value; }
        }

        public void Raise(Action<T> eventExpression, params object[] args)
        {
            _stub.Raise(eventExpression, args);
        }

        public void Raise(Action<T> eventExpression, EventArgs args)
        {
            _stub.Raise(eventExpression, args);
        }

        public ISetup<T> Setup(Expression<Action<T>> expression)
        {
            return _stub.Setup(expression);
        }

        public ISetup<T, TResult> Setup<TResult>(Expression<Func<T, TResult>> expression)
        {
            return _stub.Setup(expression);
        }

        public ISetupSequentialResult<TResult> SetupSequence<TResult>(Expression<Func<T, TResult>> expression)
        {
            return _stub.SetupSequence(expression);
        }

        public Stub<T> SetupAllProperties()
        {
            _stub.SetupAllProperties();
            return this;
        }

        public ISetupGetter<T, TProperty> SetupGet<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            return _stub.SetupGet(expression);
        }

        public Stub<T> SetupProperty<TProperty>(Expression<Func<T, TProperty>> property)
        {
            _stub.SetupProperty(property);
            return this;
        }

        public Stub<T> SetupProperty<TProperty>(Expression<Func<T, TProperty>> property, TProperty initialValue)
        {
            _stub.SetupProperty(property, initialValue);
            return this;
        }

        public ISetup<T> SetupSet(Action<T> setterExpression)
        {
            return _stub.SetupSet(setterExpression);
        }

        public ISetupSetter<T, TProperty> SetupSet<TProperty>(Action<T> setterExpression)
        {
            return _stub.SetupSet<TProperty>(setterExpression);
        }

        public override string ToString()
        {
            return _stub.ToString();
        }

        public ISetupConditionResult<T> When(Func<bool> condition)
        {
            return _stub.When(condition);
        }
    }
}