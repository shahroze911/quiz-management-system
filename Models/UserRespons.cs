//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quiz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRespons
    {
        public int ResponseID { get; set; }
        public Nullable<int> SessionID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public string UserAnswer { get; set; }
        public Nullable<bool> IsAnswerChanged { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual QuizSession QuizSession { get; set; }
    }
}
