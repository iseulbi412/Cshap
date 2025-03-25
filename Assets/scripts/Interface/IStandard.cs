using UnityEngine;
using System.Collections;
using System;
namespace Interfacetase
{
    public interface IStandard
    {
        void Run();
    }
    public class Car : IStandard
    {
        #region Field
        private string name;
        private string[] names;
        private readonly int _Length;

        #endregion
        #region Construct
        public Car()
        {
            this.name = "���� ��";

        }
        public Car(string _name)
        {
            this.name = _name;
        }
        public Car(int length)
        {
            this.name = "���� ��";
            _Length = length;
            names = new string[_Length];
        }
        #endregion
        #region Method
        public void Run()
        {
            Debug.Log($"{name}�� �޸��ϴ�");
        }
        #endregion
        #region Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return _Length; }
        }
        #endregion
        #region Distruct
        ~Car()
        {
            Debug.Log($"{name}���� ������");
        }
        #endregion
        #region Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion
        public event EventHandler Click;
        public void OnClock()
        {
            if (Click!=null)
            {
               
            }
        }
    }
}