using System;

namespace CarExcercise
{
    //THIS IS A SIMPLE CODE THAT IS SUPPOSED TO EMULATE CERTAIN CAR FUNCTIONALITIES, PLEASE FOLLOW THE INSTRUCTIONS BELOW AND COMPLETE ALL REQUESTS PROVIDED
    //**                                                                        THINGS TO ANSWER                                                                                    **//
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
    // 1. Why is this a bad design? How would you improve it? (PLEASE CHANGE CODE APPROPRIATELY)
    // Since it is a simple solution, there is not much to say. Not having your code organized may imply more difficult maintenance, a single file for each class can do the trick.
    // Adding to the engine new functionalities can be solved using a decorator instead of making it abstract and having children for each type, but it depends on the solution.
    // Since the child is not adding new properties or functionality to Engine, it could be removed.
    // 2. What is your opinion about this code?
    //      ANSWER HERE:
    // It seems Engine is ment to be abstract having each engine type as children, having thir own behaivour. Given the requirements, the engine class is not being used anyways.
    
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
    //**                                                                        THINGS TO DO                                                                                        **//
    // 1. Please create a class library and add the cs file to base on.
    // 2. Implement the StartEngine functionality. Return "Started"
    // 3. Implement the StopEngine functionality. Return "Stopped"
    // 4. Implement the MoveForward functionality. Params: meters decimal, Return $"Moved Forward {0} meters"
    // 5. Implement the MoveBackards functionality. Params: meters decimal, Return $"Moved Backwards {0} meters"
    // 6. Implement a Web Application - MVC - API to expose the functionality implemented in the last steps
    // 7. Implement a WCS Service to expose the functionality implemented in the last steps as well
    // 8. You can either create the UI and call these 2 endpoints (API/WCF) or make these calls with any API/WCF testing tool
    // 9. Please commit the project as public in git and send over the URL, don't forget to commit screenshots in case API/WCF testing tool used
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

    public class Engine { }
    public class V8 : Engine { }
    class CarExercise
    {
        private Engine _engine;
        public CarExercise()
        {
            _engine = new Engine();
        }
    }

}


