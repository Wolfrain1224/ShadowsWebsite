using System;


namespace ShadowsWebsite.Common.StateManagement
{
    public class AgeCheck
    {
        private DateTime _check;
        private string _set;
        private int _age;
        public DateTime ageCheck
        {
            get => _check;
            set
            {
                _check = value;
                NotifyStateChanged();
            }
        }
       
        public string Set
        {
            get => _set;
            set
            {
                _set = value;
                NotifyStateChanged();
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                NotifyStateChanged();
            }
        }
        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        public void CheckAge()
        {
            _age = Getage(_check);
            
            // var age = today.Year - _check.Year;
            if (_age > 18) 
            {
                _set = "Worked";
            }
            else
            {
                _set = "Did not work";
            }
            NotifyStateChanged();
        }

        public int Getage(DateTime bornDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bornDate.Year;
            if (bornDate > today.AddYears(-age)) 
                age--;

            return age;
        }
       
    }
}