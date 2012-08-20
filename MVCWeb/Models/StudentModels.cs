using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWeb.Models
{
  public class PLStudent
  {
    [Required] // others like [StringLength] [RegularExpression] [Range] can also available.
    [DisplayName("Student ID")] // display the label when using <%: Html.DisplayForModel() %>
    public string ID { get; set; }

    [Required]
    [StringLength(9)]
    [DisplayName("Social Security #")]
    public string SSN { get; set; }

    [Required]
    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [Required]
    [DisplayName("Last Name")]
    public string LastName { get; set; }

    [Required]
    [DisplayName("Email")] // you could use [RegularExpression]
    // [RegularExpression("regex pattern goes here...")]
    public string EmailAddress { get; set; }

    [Required]
    [DisplayName("Password")]
    [ScaffoldColumn(false)] // don't show this in <%: Html.DisplayForModel() %>
    public string Password { get; set; }

    [DisplayName("Enrollment")]
    public List<PLSchedule> Enrollments { get; set; }
  }

  public static class StudentClientService
  {
    public static List<PLStudent> GetStudentList()
    {
      List<PLStudent> studentList = new List<PLStudent>();

      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();

      string[] errors = new string[0];
      SLStudent.Student[] studentsLoaded = SLStudent.GetStudentList(ref errors);

      foreach (SLStudent.Student s in studentsLoaded)
      {
        PLStudent student = DTO_to_PL(s);
        studentList.Add(student);
      }

      return studentList;
    }

    /// <summary>
    /// create a new student
    /// </summary>
    /// <param name="s"></param>
    public static void CreateStudent(PLStudent s)
    {
      SLStudent.Student newStudent = DTO_to_SL(s);

      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();
      string[] errors = new string[0];
      SLStudent.InsertStudent(newStudent, ref errors);
    }

    /// <summary>
    /// update existing student info
    /// </summary>
    /// <param name="s"></param>
    public static void UpdateStudent(PLStudent s)
    {
      SLStudent.Student newStudent = DTO_to_SL(s);

      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();
      string[] errors = new string[0];
      SLStudent.UpdateStudent(newStudent, ref errors);
    }

    /// <summary>
    /// Get student detail
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static PLStudent GetStudentDetail(string id)
    {
      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();

      string[] errors = new string[0];
      SLStudent.Student newStudent = SLStudent.GetStudent(id, ref errors);

      // this is the data transfer object code...
      return DTO_to_PL(newStudent);
    }

    /// <summary>
    /// call service layer's delete student method
    /// </summary>
    /// <param name="id"></param>
    public static void Delete(string id)
    {
      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();
      string[] errors = new string[0];
      SLStudent.DeleteStudent(id, ref errors);
    }

    /// <summary>
    /// call service layer's delete student method
    /// </summary>
    /// <param name="id"></param>

    public static void Enroll(string student_id, int schedule_id)
    {
      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();
      string[] errors = new string[0];
      SLStudent.EnrollSchedule(student_id, schedule_id, ref errors);
    }

    /// <summary>
    /// call service layer's drop student method
    /// </summary>
    /// <param name="id"></param>
    public static void Drop(string student_id, int schedule_id)
    {
      SLStudent.ISLStudent SLStudent = new SLStudent.SLStudentClient();
      string[] errors = new string[0];
      SLStudent.DropEnrolledSchedule(student_id, schedule_id, ref errors);
    }

    /// <summary>
    /// This is the data transfer object for student.
    /// Converting business layer student object to presentation layer student object
    /// </summary>
    /// <param name="student"></param>
    /// <returns></returns>
    private static PLStudent DTO_to_PL(SLStudent.Student student)
    {
      PLStudent PLStudent = new Models.PLStudent();
      PLStudent.ID = student.id;
      PLStudent.FirstName = student.first_name;
      PLStudent.LastName = student.last_name;
      PLStudent.SSN = student.ssn;
      PLStudent.EmailAddress = student.email;
      PLStudent.Password = student.password;

      if (student.enrolled != null)
      {
        PLStudent.Enrollments = new List<PLSchedule>();
        foreach (SLStudent.Schedule schedule in student.enrolled)
        {
          PLSchedule s = DTO_to_PL(schedule); // method overloading
          PLStudent.Enrollments.Add(s);
        }
      }
      return PLStudent;
    }

    /// <summary>
    /// this is data transfer object for student.
    /// Converting from presentation layer student object to business layer student object
    /// </summary>
    /// <param name="student"></param>
    /// <returns></returns>
    private static SLStudent.Student DTO_to_SL(PLStudent student)
    {
      SLStudent.Student SLStudent = new MVCWeb.SLStudent.Student();
      SLStudent.id = student.ID;
      SLStudent.ssn = student.SSN;
      SLStudent.first_name = student.FirstName;
      SLStudent.last_name = student.LastName;
      SLStudent.email = student.EmailAddress;
      SLStudent.password= student.Password;

      return SLStudent;
    }

    private static PLSchedule DTO_to_PL(SLStudent.Schedule s)
    {
      PLSchedule mySchedule = new PLSchedule();

      mySchedule.schedule_id = s.id;
      mySchedule.year = s.year;
      mySchedule.quarter = s.quarter;
      mySchedule.session = s.session;
      mySchedule.course_title = s.course.title;
      mySchedule.course_description = s.course.description;

      return mySchedule;
    }


  }
}