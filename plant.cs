using System;

namespace PlantTracker
{
    public class Plant{
        private string _name;
        private int _waterIntake;
        private int _foodLevel;
        private string _growth;
        private int _sunshine;


        public Plant(string name, int waterIntake, int foodLevel, int sunshine)
        {
            _name = name;
            _waterIntake = waterIntake;
            _foodLevel = foodLevel;
            _sunshine = sunshine;
            _growth = Growth();

        }

        // Get plant name from user
        public string GetName(){
            return _name;
        }
        // Set plant Name
        public void SetName(string name){
            _name = name;          
        }
    //  Public Method
        public void DetermineNextSteps()
        {
            GiveWater();
            FeedThePlant();
            GiveSunshine();
            Growth();
        }
        // Private Method
        private void GiveWater(){
         _waterIntake++;
        }
        private void FeedThePlant()
        {
         _foodLevel++;
        }

        private void GiveSunshine()
        {
             _sunshine++;
        }
        private string Growth()
        {
            if(_foodLevel == 1 && _sunshine == 1 && _waterIntake ==1)
            {
                _growth = "planted seed";
            }
            else if (_foodLevel == 2 && _sunshine == 2 && _waterIntake ==2)
            {
                _growth = "sprouted";
            }
            else if (_foodLevel == 3 && _sunshine == 3 && _waterIntake ==3)
            {
                _growth = "seedling";
            }
            else if (_foodLevel == 4 && _sunshine == 4 && _waterIntake ==4)
            {
                _growth = "vegetative";
            }
            else if (_foodLevel == 5 && _sunshine == 5 && _waterIntake ==5)
            {
                _growth = "budding";
            }
            else if (_foodLevel == 6 && _sunshine == 6 && _waterIntake ==6)
            {
                _growth = "flowering";
            }
            else if (_foodLevel == 7 && _sunshine == 7 && _waterIntake ==7)
            {
                _growth = "ripening";
            }
            else
            {
                Console.WriteLine("Wait for plant to reach next stage");
            }
        }

    }
    
}