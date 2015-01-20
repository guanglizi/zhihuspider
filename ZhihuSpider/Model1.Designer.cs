﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ZhihuSpider
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Model1Container : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Model1Container object using the connection string found in the 'Model1Container' section of the application configuration file.
        /// </summary>
        public Model1Container() : base("name=Model1Container", "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(string connectionString) : base(connectionString, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(EntityConnection connection) : base(connection, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Question> QuestionSet
        {
            get
            {
                if ((_QuestionSet == null))
                {
                    _QuestionSet = base.CreateObjectSet<Question>("QuestionSet");
                }
                return _QuestionSet;
            }
        }
        private ObjectSet<Question> _QuestionSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Answer> AnswerSet
        {
            get
            {
                if ((_AnswerSet == null))
                {
                    _AnswerSet = base.CreateObjectSet<Answer>("AnswerSet");
                }
                return _AnswerSet;
            }
        }
        private ObjectSet<Answer> _AnswerSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the QuestionSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToQuestionSet(Question question)
        {
            base.AddObject("QuestionSet", question);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AnswerSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAnswerSet(Answer answer)
        {
            base.AddObject("AnswerSet", answer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Answer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Answer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Answer object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="voteup">Initial value of the Voteup property.</param>
        /// <param name="collectCount">Initial value of the CollectCount property.</param>
        /// <param name="commentCount">Initial value of the CommentCount property.</param>
        /// <param name="questionId">Initial value of the QuestionId property.</param>
        public static Answer CreateAnswer(global::System.Decimal id, global::System.Decimal voteup, global::System.Decimal collectCount, global::System.Decimal commentCount, global::System.Decimal questionId)
        {
            Answer answer = new Answer();
            answer.Id = id;
            answer.Voteup = voteup;
            answer.CollectCount = collectCount;
            answer.CommentCount = commentCount;
            answer.QuestionId = questionId;
            return answer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Decimal _Id;
        partial void OnIdChanging(global::System.Decimal value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Voteup
        {
            get
            {
                return _Voteup;
            }
            set
            {
                OnVoteupChanging(value);
                ReportPropertyChanging("Voteup");
                _Voteup = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Voteup");
                OnVoteupChanged();
            }
        }
        private global::System.Decimal _Voteup;
        partial void OnVoteupChanging(global::System.Decimal value);
        partial void OnVoteupChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                OnCreateTimeChanging(value);
                ReportPropertyChanging("CreateTime");
                _CreateTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateTime");
                OnCreateTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _CreateTime;
        partial void OnCreateTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnCreateTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal CollectCount
        {
            get
            {
                return _CollectCount;
            }
            set
            {
                OnCollectCountChanging(value);
                ReportPropertyChanging("CollectCount");
                _CollectCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CollectCount");
                OnCollectCountChanged();
            }
        }
        private global::System.Decimal _CollectCount;
        partial void OnCollectCountChanging(global::System.Decimal value);
        partial void OnCollectCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal CommentCount
        {
            get
            {
                return _CommentCount;
            }
            set
            {
                OnCommentCountChanging(value);
                ReportPropertyChanging("CommentCount");
                _CommentCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CommentCount");
                OnCommentCountChanged();
            }
        }
        private global::System.Decimal _CommentCount;
        partial void OnCommentCountChanging(global::System.Decimal value);
        partial void OnCommentCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                OnQuestionIdChanging(value);
                ReportPropertyChanging("QuestionId");
                _QuestionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuestionId");
                OnQuestionIdChanged();
            }
        }
        private global::System.Decimal _QuestionId;
        partial void OnQuestionIdChanging(global::System.Decimal value);
        partial void OnQuestionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AuthorId
        {
            get
            {
                return _AuthorId;
            }
            set
            {
                OnAuthorIdChanging(value);
                ReportPropertyChanging("AuthorId");
                _AuthorId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AuthorId");
                OnAuthorIdChanged();
            }
        }
        private global::System.String _AuthorId;
        partial void OnAuthorIdChanging(global::System.String value);
        partial void OnAuthorIdChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Question")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Question : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Question object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="answerCount">Initial value of the AnswerCount property.</param>
        /// <param name="topic">Initial value of the Topic property.</param>
        /// <param name="followerCount">Initial value of the FollowerCount property.</param>
        /// <param name="viewCount">Initial value of the ViewCount property.</param>
        /// <param name="questionId">Initial value of the QuestionId property.</param>
        public static Question CreateQuestion(global::System.Decimal id, global::System.String title, global::System.Decimal answerCount, global::System.String topic, global::System.Decimal followerCount, global::System.Decimal viewCount, global::System.Decimal questionId)
        {
            Question question = new Question();
            question.Id = id;
            question.Title = title;
            question.AnswerCount = answerCount;
            question.Topic = topic;
            question.FollowerCount = followerCount;
            question.ViewCount = viewCount;
            question.QuestionId = questionId;
            return question;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Decimal _Id;
        partial void OnIdChanging(global::System.Decimal value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal AnswerCount
        {
            get
            {
                return _AnswerCount;
            }
            set
            {
                OnAnswerCountChanging(value);
                ReportPropertyChanging("AnswerCount");
                _AnswerCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AnswerCount");
                OnAnswerCountChanged();
            }
        }
        private global::System.Decimal _AnswerCount;
        partial void OnAnswerCountChanging(global::System.Decimal value);
        partial void OnAnswerCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                OnCreateTimeChanging(value);
                ReportPropertyChanging("CreateTime");
                _CreateTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateTime");
                OnCreateTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _CreateTime;
        partial void OnCreateTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnCreateTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Topic
        {
            get
            {
                return _Topic;
            }
            set
            {
                OnTopicChanging(value);
                ReportPropertyChanging("Topic");
                _Topic = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Topic");
                OnTopicChanged();
            }
        }
        private global::System.String _Topic;
        partial void OnTopicChanging(global::System.String value);
        partial void OnTopicChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal FollowerCount
        {
            get
            {
                return _FollowerCount;
            }
            set
            {
                OnFollowerCountChanging(value);
                ReportPropertyChanging("FollowerCount");
                _FollowerCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FollowerCount");
                OnFollowerCountChanged();
            }
        }
        private global::System.Decimal _FollowerCount;
        partial void OnFollowerCountChanging(global::System.Decimal value);
        partial void OnFollowerCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal ViewCount
        {
            get
            {
                return _ViewCount;
            }
            set
            {
                OnViewCountChanging(value);
                ReportPropertyChanging("ViewCount");
                _ViewCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ViewCount");
                OnViewCountChanged();
            }
        }
        private global::System.Decimal _ViewCount;
        partial void OnViewCountChanging(global::System.Decimal value);
        partial void OnViewCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                OnQuestionIdChanging(value);
                ReportPropertyChanging("QuestionId");
                _QuestionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuestionId");
                OnQuestionIdChanged();
            }
        }
        private global::System.Decimal _QuestionId;
        partial void OnQuestionIdChanging(global::System.Decimal value);
        partial void OnQuestionIdChanged();

        #endregion
    
    }

    #endregion
    
}
