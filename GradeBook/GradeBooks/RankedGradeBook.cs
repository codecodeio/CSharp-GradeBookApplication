using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked grading requires a minimum of 5 students.");
            }
            else
            {
                //calculate bucket size
                var bucketSize = (int)Math.Ceiling(Students.Count * 0.2);
                
                Console.WriteLine("BucketSize: " + bucketSize);
                //create sorted average grade list
                SortedList studentList = new SortedList();
                int i = 0;
                foreach (Student student in Students)
                {
                    studentList.Add(i,student.AverageGrade);
                    i++;
                }
                IList vl = studentList.GetValueList();
                //loop over sorted values
                for (i = 0; i < studentList.Count; i++){
                    Console.WriteLine(vl[i]);
                    if(averageGrade >= (double)vl[i])
                    {
                        i++;
                        break;
                    }
                }

                Console.WriteLine("Bucket: " + i);
                if (i <= bucketSize)
                    return 'A';
                else if (i <= bucketSize*2)
                    return 'B';
                else if (i <= bucketSize * 3)
                    return 'C';
                else if (i <= bucketSize * 4)
                    return 'D';
                else
                    return 'F';
            }
           
        }
    }
}
