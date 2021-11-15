namespace ScoreDatabase.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ScoreManagerDbContext : DbContext
    {
        public ScoreManagerDbContext()
            : base("name=ScoreManagerDbContext")
        {
        }

        public virtual DbSet<CERTIFICATE_BAND> CERTIFICATE_BAND { get; set; }
        public virtual DbSet<CLASS> CLASSes { get; set; }
        public virtual DbSet<COMPETITION> COMPETITIONs { get; set; }
        public virtual DbSet<COMPETITION_PRIZE> COMPETITION_PRIZE { get; set; }
        public virtual DbSet<Course_Group_E_Sub> Course_Group_E_Sub { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<DISCIPLINE> DISCIPLINEs { get; set; }
        public virtual DbSet<ENTRANCE_SUBJECT> ENTRANCE_SUBJECT { get; set; }
        public virtual DbSet<EXAM_FORM> EXAM_FORM { get; set; }
        public virtual DbSet<FACULTY> FACULTies { get; set; }
        public virtual DbSet<FOREIGN_LANGUAGE> FOREIGN_LANGUAGE { get; set; }
        public virtual DbSet<Group_E_Sub_E_Sub> Group_E_Sub_E_Sub { get; set; }
        public virtual DbSet<GROUP_E_SUBJECT> GROUP_E_SUBJECT { get; set; }
        public virtual DbSet<GROUP_SUBJECTS> GROUP_SUBJECTS { get; set; }
        public virtual DbSet<LANGUAGE_CERTIFICATE> LANGUAGE_CERTIFICATE { get; set; }
        public virtual DbSet<LEADERSHIP_PROCESS> LEADERSHIP_PROCESS { get; set; }
        public virtual DbSet<LECTURER> LECTURERs { get; set; }
        public virtual DbSet<Lecturer_Department> Lecturer_Department { get; set; }
        public virtual DbSet<Lecturer_L_Certificate> Lecturer_L_Certificate { get; set; }
        public virtual DbSet<Lecturer_majorclass> Lecturer_majorclass { get; set; }
        public virtual DbSet<MAJOR> MAJORs { get; set; }
        public virtual DbSet<MAJOR_CLASS> MAJOR_CLASS { get; set; }
        public virtual DbSet<Major_Class_Term> Major_Class_Term { get; set; }
        public virtual DbSet<PROFESSIONAL_QUALIFICATION> PROFESSIONAL_QUALIFICATION { get; set; }
        public virtual DbSet<S_CERTIFICATE_SCORE> S_CERTIFICATE_SCORE { get; set; }
        public virtual DbSet<SCHOLARSHIP> SCHOLARSHIPs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
        public virtual DbSet<Student_Class> Student_Class { get; set; }
        public virtual DbSet<Student_Competition_Prize> Student_Competition_Prize { get; set; }
        public virtual DbSet<Student_Course_Optionalsub> Student_Course_Optionalsub { get; set; }
        public virtual DbSet<Student_Discipline> Student_Discipline { get; set; }
        public virtual DbSet<Student_E_Sub> Student_E_Sub { get; set; }
        public virtual DbSet<Student_Lang_Certificate> Student_Lang_Certificate { get; set; }
        public virtual DbSet<Student_Major_Class> Student_Major_Class { get; set; }
        public virtual DbSet<Student_Scholarship_Major> Student_Scholarship_Major { get; set; }
        public virtual DbSet<Student_Subject_Major_Class> Student_Subject_Major_Class { get; set; }
        public virtual DbSet<Subject_Exam_Form> Subject_Exam_Form { get; set; }
        public virtual DbSet<Subject_Subjectgroup> Subject_Subjectgroup { get; set; }
        public virtual DbSet<SUBJECT> SUBJECTS { get; set; }
        public virtual DbSet<Subjects_Condi_Subjects> Subjects_Condi_Subjects { get; set; }
        public virtual DbSet<TERM> TERMs { get; set; }
        public virtual DbSet<TRAINING_PROGRAMME> TRAINING_PROGRAMME { get; set; }
        public virtual DbSet<TRAINING_PROGRAMME_COURSE> TRAINING_PROGRAMME_COURSE { get; set; }
        public virtual DbSet<WORKING_PROCESS> WORKING_PROCESS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CERTIFICATE_BAND>()
                .Property(e => e.Certificate_Score_Id)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICATE_BAND>()
                .Property(e => e.Lecturer_Lang_Certificate_Id)
                .IsUnicode(false);

            modelBuilder.Entity<CERTIFICATE_BAND>()
                .Property(e => e.Certificate_Score_Level)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.Class_Id)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.Lecturer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.Term_Id)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS>()
                .Property(e => e.Class_Password)
                .IsUnicode(false);

            modelBuilder.Entity<COMPETITION_PRIZE>()
                .Property(e => e.Competition_Prize_Bonus_Point)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Course_Group_E_Sub>()
                .Property(e => e.Group_E_Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Course_Group_E_Sub>()
                .Property(e => e.Training_programme_course_Id)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.Department_Id)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.Department_Email)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.Department_Phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.Faculty_Id)
                .IsUnicode(false);

            modelBuilder.Entity<DISCIPLINE>()
                .Property(e => e.Discipline_Name)
                .IsUnicode(false);

            modelBuilder.Entity<FACULTY>()
                .Property(e => e.Faculty_Id)
                .IsUnicode(false);

            modelBuilder.Entity<FACULTY>()
                .Property(e => e.Faculty_Email)
                .IsUnicode(false);

            modelBuilder.Entity<FACULTY>()
                .Property(e => e.Faculty_Phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<Group_E_Sub_E_Sub>()
                .Property(e => e.Group_E_Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<GROUP_E_SUBJECT>()
                .Property(e => e.Group_E_Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<GROUP_SUBJECTS>()
                .Property(e => e.Group_Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<GROUP_SUBJECTS>()
                .Property(e => e.Training_programme_course_Id)
                .IsUnicode(false);

            modelBuilder.Entity<LANGUAGE_CERTIFICATE>()
                .Property(e => e.Language_certificate_Name)
                .IsUnicode(false);

            modelBuilder.Entity<LECTURER>()
                .Property(e => e.Lecturer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<LECTURER>()
                .Property(e => e.Lecturer_Phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<LECTURER>()
                .Property(e => e.Lecturer_Email)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_Department>()
                .Property(e => e.Lecturer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_Department>()
                .Property(e => e.Department_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_L_Certificate>()
                .Property(e => e.Lecturer_Lang_Certificate_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_L_Certificate>()
                .Property(e => e.Lecturer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_L_Certificate>()
                .Property(e => e.Language_certificate_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_majorclass>()
                .Property(e => e.Major_class_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer_majorclass>()
                .Property(e => e.Lecturer_Id)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR>()
                .Property(e => e.Major_Id)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR>()
                .Property(e => e.Faculty_Id)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR_CLASS>()
                .Property(e => e.Major_class_Id)
                .IsUnicode(false);

            modelBuilder.Entity<MAJOR_CLASS>()
                .Property(e => e.Training_programme_course_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Major_Class_Term>()
                .Property(e => e.Major_Class_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Major_Class_Term>()
                .Property(e => e.Term_Id)
                .IsUnicode(false);

            modelBuilder.Entity<PROFESSIONAL_QUALIFICATION>()
                .Property(e => e.Professional_qualification_Id)
                .IsUnicode(false);

            modelBuilder.Entity<S_CERTIFICATE_SCORE>()
                .Property(e => e.S_Certificate_Score_Level)
                .IsUnicode(false);

            modelBuilder.Entity<SCHOLARSHIP>()
                .Property(e => e.Scholarship_Currency)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.Student_Email)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.Student_Phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.Student_IDcardnumber)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.Student_Passport_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Class_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Student_Class_Point1)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Student_Class_Point2)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Student_Class_Point3)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Point1_Coefficient)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Poinr2_Coefficient)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Point3_Coefficient)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Student_Class_Averagepoint)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.Student_Class_4_Avgpoint)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Student_Class>()
                .Property(e => e.AvgPointbyLetter)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Competition_Prize>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Course_Optionalsub>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Discipline>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Lang_Certificate>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Lang_Certificate>()
                .Property(e => e.Language_certificate_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.Major_class_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.Student_Major_Class_CPA)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.Student_Major_Class_Test)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.Training_programme_course_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.TongTichLuy)
                .HasPrecision(7, 1);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.TongTichLuy10)
                .HasPrecision(7, 1);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.DiemTB10)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student_Major_Class>()
                .Property(e => e.Bonus_Point)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Student_Scholarship_Major>()
                .Property(e => e.Student_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Subject_Major_Class>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Student_Subject_Major_Class>()
                .Property(e => e.AveragePoint)
                .HasPrecision(5, 1);

            modelBuilder.Entity<Student_Subject_Major_Class>()
                .Property(e => e.AvgPoint10)
                .HasPrecision(5, 1);

            modelBuilder.Entity<Student_Subject_Major_Class>()
                .Property(e => e.AvgPointbyLetter)
                .IsUnicode(false);

            modelBuilder.Entity<Subject_Exam_Form>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Subject_Subjectgroup>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Subject_Subjectgroup>()
                .Property(e => e.Group_Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<SUBJECT>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<SUBJECT>()
                .Property(e => e.Department_Id)
                .IsUnicode(false);

            modelBuilder.Entity<SUBJECT>()
                .HasMany(e => e.Subjects_Condi_Subjects)
                .WithOptional(e => e.SUBJECT)
                .HasForeignKey(e => e.Conditional_subject);

            modelBuilder.Entity<SUBJECT>()
                .HasMany(e => e.Subjects_Condi_Subjects1)
                .WithOptional(e => e.SUBJECT1)
                .HasForeignKey(e => e.Subject_Id);

            modelBuilder.Entity<Subjects_Condi_Subjects>()
                .Property(e => e.Subject_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Subjects_Condi_Subjects>()
                .Property(e => e.Conditional_subject)
                .IsUnicode(false);

            modelBuilder.Entity<TERM>()
                .Property(e => e.Term_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_PROGRAMME>()
                .Property(e => e.Training_programme_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_PROGRAMME>()
                .Property(e => e.Professional_qualification_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_PROGRAMME>()
                .Property(e => e.Major_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_PROGRAMME_COURSE>()
                .Property(e => e.Training_programme_course_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_PROGRAMME_COURSE>()
                .Property(e => e.Training_programme_Id)
                .IsUnicode(false);

            modelBuilder.Entity<TRAINING_PROGRAMME_COURSE>()
                .Property(e => e.TCP_length)
                .HasPrecision(3, 1);
        }
    }
}
