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
            #endregion
        }
    }
}
