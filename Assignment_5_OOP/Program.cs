namespace Assignment_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1  Object Copying

            //QA:
            //Q:What happens when you assign one object variable to another object variable?

            /*Ans: When we assign one object reference to another,
             * both references point to the same object in memory. 
             * No new object or copy of the data is created.
             */

            //==========================================================

            //QB:
            //Q:b) Does assigning one object to another create a new object? Explain

            /*Ans:
             * No not create a new object , both point to same object in memory
             */

            //==========================================================

            //QC:
            //Q: What is the difference between copying an object and copying its reference?

            /*Ans:
             *  In copying an object two object in stack have diffrent address but in heap point to same object
             *  In copying its reference two variable in stack have same address(copy address) so two variable ref
                to same data in heap
             */
            #endregion

            #region Q2  Shallow Copy vs Deep Copy

            //QA
            //Q: What is a Shallow Copy? 

            /*Ans:
             * Creat a new object and copies all value_typ fileds 
             * For refernce_typ fileds only refernce (linkes) are copied - bothe objects point to
               the same nasted objects
             */

            //==========================================================

            //QB:
            //Q: What is a Deep Copy? 

            /*Ans:
             * Creat a new object and recursively copies all nasted objects
             * The original and the copy are completely independent
             */

            //==========================================================

            //QC:
            //Q: What happens to reference-type members when a Shallow Copy is created? 

            /*Ans:
             * copy address so both point to same data in heap
             */

            //==========================================================

            //QD
            //Q:What happens to reference-type members when a Deep Copy is created? 

            /*Ans:
             * Creat new object with thier own copies of all nasted objects
             */

            //==========================================================

            //QE
            //Q: Give one situation where Deep Copy would be safer than Shallow Copy

            /*Ans:
             * Deep Copy is safer when we need two completely independent objects
             * For example ==> when copying  object that contains an Address object
             * Deep Copy changes the copied Address do not affect the original object
             */
            #endregion
            #endregion
        }
    }
}
