using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Buffers;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name,isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
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
                
                //Console.WriteLine("BucketSize: " + bucketSize);
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
                    //Console.WriteLine(vl[i]);
                    if(averageGrade >= (double)vl[i])
                    {
                        i++;
                        break;
                    }
                }

                //Console.WriteLine("Bucket: " + i);
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
