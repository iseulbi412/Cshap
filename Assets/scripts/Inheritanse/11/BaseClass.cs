using UnityEngine;
using UnityEngine.Accessibility;
namespace Inheritance11
{
    public class BaseClass
    {
        private string word;
        protected string Word
        {
            get { return word; }
            set { word = value; }
        }
    }
    public class SubClass : BaseClass
    {
        public void SetWord(string _word)
        {
            base.Word = _word;
        }
        public string GetWord()
        {
            return base.Word;
        }
    }

}