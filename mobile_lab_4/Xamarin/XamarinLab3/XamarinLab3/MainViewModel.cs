using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinLab3
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                    return;
                name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public string DisplayName => $"Name Entered: {Name}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        string lastName = string.Empty;

        public string LastName
        {
            get => lastName;

            set
            {
                if (lastName == value)
                    return;
                lastName = value;
                OnPropertyChangedLastName(nameof(lastName));
                OnPropertyChangedLastName(nameof(DisplayLastName));
            }

        }

        public string DisplayLastName => $"LastName Entered: {LastName}";

        void OnPropertyChangedLastName(string lastName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(lastName));
        }
        

        string phoneNumber = string.Empty;

        public string PhoneNumber
        {
            get => phoneNumber;

            set
            {
                if (phoneNumber == value)
                    return;

                phoneNumber = value;
                OnPropertyChangedPhoneNumber(nameof(phoneNumber));
                OnPropertyChangedPhoneNumber(nameof(DisplayPhoneNumber));
            }

        }

        public string DisplayPhoneNumber => $"Phone Entered: {PhoneNumber}";
        void OnPropertyChangedPhoneNumber(string phoneNumber)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(phoneNumber));
        }
    }
}
