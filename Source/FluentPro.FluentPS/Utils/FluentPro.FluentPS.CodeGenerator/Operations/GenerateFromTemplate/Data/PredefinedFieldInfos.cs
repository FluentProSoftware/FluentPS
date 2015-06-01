using System;
using System.Collections.Generic;
using FluentPro.FluentPS.Model;

namespace FluentPro.FluentPS.CodeGenerator.Operations.GenerateFromTemplate.Data
{
    public class PredefinedFieldInfos
    {
        public static readonly List<PsFieldInfo> Overrides = new List<PsFieldInfo>
        {
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_AUTHOR", DbName = "ProjectAuthorName", DisplayName = "Author" },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_CATEGORY", DbName = "ProjectCategoryName", DisplayName = "Category"},
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_COMPANY", DbName = "ProjectCompanyName", DisplayName = "Company"},
            new PsFieldInfo { TableName = "Project", PsName = "CREATED_DATE", DbName = "ProjectCreatedDate", DisplayName = "Created", DataType = typeof(DateTime), IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "WPROJ_DESCRIPTION", DbName = "ProjectDescription", DisplayName = "Description"},
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_UID", DbName = "ProjectUID", DisplayName = "Enterprise Project ID", DataType = typeof(Guid), IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_KEYWORDS", DbName = "ProjectKeywords", DisplayName = "Keywords" },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_MANAGER", DbName = "ProjectManagerName", DisplayName = "Manager" },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_NAME", DbName = "ProjectName", DisplayName = "Project Name" },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_SUBJECT", DbName = "ProjectSubject", DisplayName = "Subject" },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_PROP_TITLE", DbName = "ProjectTitle", DisplayName = "Title" },
            new PsFieldInfo { TableName = "Project", PsName = "ENTERPRISE_PROJECT_TYPE_UID", DbName = "EnterpriseProjectTypeUID", DisplayName = "Enterprise Project Type ID", DataType = typeof(Guid), IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "ENTERPRISE_PROJECT_TYPE_NAME", DbName = "EnterpriseProjectTypeName", DisplayName = "Enterprise Project Type Name", IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "PHASE_UID", DbName = "PhaseUID", DisplayName = "Phase ID", DataType = typeof(Guid), IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "PHASE_NAME", DbName = "PhaseName", DisplayName = "Phase Name", IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "STAGE_UID", DbName = "StageUID", DisplayName = "Stage ID", DataType = typeof(Guid), IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "STAGE_NAME", DbName = "StageName", DisplayName = "Stage Name", IsUpdatable = false },
            new PsFieldInfo { TableName = "Project", PsName = "PROJ_TYPE", DbName = "ProjectType", DisplayName = "Project DataType", IsUpdatable = false },
            
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "PROJ_CHECKOUTBY", Title = "Checked Out By"},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "PLANNER_END_DATE", Title = "Committed Planned End Date", DataType = typeof(DateTime)},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "PLANNER_START_DATE", Title = "Committed Planned Start Date", DataType = typeof(DateTime)},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "OPTIMIZER_DECISION", Title = "Committed Portfolio Selection Decision (Cost)", DataType = typeof(decimal)},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "PLANNER_DECISION", Title = "Committed Portfolio Selection Decision (Schedule)"},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "PROJ_LAST_SAVED", Title = "Last Modified", DataType = typeof(DateTime)},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "WPROJ_LAST_PUB", Title = "Last Published", DataType = typeof(DateTime)},
            //new PsFieldInfo { EntityType = PsEntityType.Project, PsiName = "PROJ_OPT_MINUTES_PER_DAY", Title = "Minutes Per Day", DataType = typeof(decimal)},
      
        
            new PsFieldInfo { TableName = "Task", PsName = "TASK_PCT_COMP", DbName = "TaskPercentCompleted", DisplayName = "% Complete", DataType = typeof(decimal) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_PCT_WORK_COMP", DbName = "TaskPercentWorkCompleted", DisplayName = "% Work Complete", DataType = typeof(decimal) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_ACTIVE", DbName = "TaskIsActive", DisplayName = "Active", DataType = typeof(bool) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_COST", DbName = "TaskActualCost", DisplayName = "Actual Cost", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_DUR", DbName = "TaskActualDuration", DisplayName = "Actual Duration", DataType = typeof(decimal), IsUpdatable = false },// 
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_FINISH", DbName = "TaskActualFinishDate", DisplayName = "Actual Finish", DataType = typeof(DateTime), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_OVT_COST", DbName = "TaskActualOvertimeCost", DisplayName = "Actual Overtime Cost", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_OVT_WORK", DbName = "TaskActualOvertimeWork", DisplayName = "Actual Overtime Work", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_START", DbName = "TaskActualStart", DisplayName = "Actual Start", DataType = typeof(DateTime), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_ACT_WORK", DbName = "TaskActualWork", DisplayName = "Actual Work", DataType = typeof(decimal) },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_ACWP", DbName = "TaskACWP", DisplayName = "ACWP", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_BCWP", DbName = "TaskBCWP", DisplayName = "BCWP", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_BCWS", DbName = "TaskBCWS", DisplayName = "BCWS", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_BUDGET_COST", DbName = "TaskBudgetCost", DisplayName = "Budget Cost", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_BUDGET_WORK", DbName = "TaskBudgetWork", DisplayName = "Budget Work", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_COST", DbName = "TaskCost", DisplayName = "Cost", DataType = typeof(decimal) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_COST_VAR", DbName = "TaskCostVariance", DisplayName = "Cost Variance", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_CPI", DbName = "TaskCPI", DisplayName = "CPI", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "CREATED_DATE", DbName = "TaskCreatedDate", DisplayName = "Task Created", DataType = typeof(DateTime), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_CRITICAL", DbName = "TaskIsCritical", DisplayName = "Critical", DataType = typeof(bool), IsUpdatable = false },
            new PsFieldInfo { TableName = "Task", PsName = "TASK_CV", DbName = "TaskCV", DisplayName = "CV", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TaskCVP", DbName = "TaskCVP", DisplayName = "CVP", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_DEADLINE", DbName = "TaskDeadline", DisplayName = "Deadline", DataType = typeof(DateTime) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_DUR", DbName = "TaskDuration", DisplayName = "Duration", DataType = typeof(decimal) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_DUR_VAR", DbName = "TaskDurationVariance", DisplayName = "Duration Variance", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_EAC", DbName = "TaskEAC", DisplayName = "EAC", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_EARLY_FINISH", DbName = "TaskEarlyFinish", DisplayName = "Early Finish", DataType = typeof(DateTime), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_EARLY_START", DbName = "TaskEarlyStart", DisplayName = "Early Start", DataType = typeof(DateTime), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_EFFORT_DRIVEN", DbName = "TaskIsEffortDriven", DisplayName = "Effort Driven", DataType = typeof(bool), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "PROJ_UID", DbName = "ProjectUID", DisplayName = "Enterprise Project ID", DataType = typeof(Guid), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_DUR_IS_EST", DbName = "TaskDurationIsEstimated", DisplayName = "Estimated", DataType = typeof(bool) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_EXTERNAL", DbName = "TaskIsExternal", DisplayName = "External Task", DataType = typeof(bool), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_FINISH_DATE", DbName = "TaskFinishDate", DisplayName = "Finish", DataType = typeof(DateTime) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_FINISH_VAR", DbName = "TaskFinishVariance", DisplayName = "Finish Variance", IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_FIXED_COST", DbName = "TaskFixedCost", DisplayName = "Fixed Cost", DataType = typeof(decimal) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_FREE_SLACK", DbName = "TaskFreeSlack", DisplayName = "Free Slack", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_HYPERLINK_FRIENDLY_NAME", DbName = "TaskHyperLinkFriendlyName", DisplayName = "Hyperlink", IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_HYPERLINK_ADDRESS", DbName = "TaskHyperLinkAddress", DisplayName = "Hyperlink Address", IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_ID", DbName = "TaskIndex", DisplayName = "ID", DataType = typeof(int), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_IGNORES_RES_CAL", DbName = "TaskIgnoresResourceCalendar", DisplayName = "Ignore Resource Calendar", DataType = typeof(bool), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "MOD_DATE", DbName = "TaskModifiedDate", DisplayName = "Last Modified", DataType = typeof(DateTime), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_LATE_FINISH", DbName = "TaskLateFinish", DisplayName = "Late Finish", DataType = typeof(DateTime), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_LATE_START", DbName = "TaskLateStart", DisplayName = "Late Start", DataType = typeof(DateTime), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_LEVELING_DELAY", DbName = "TaskLevelingDelay", DisplayName = "Leveling Delay", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_MARKED", DbName = "TaskIsMarked", DisplayName = "Marked", DataType = typeof(bool) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_MILESTONE", DbName = "TaskIsMilestone", DisplayName = "Milestone", DataType = typeof(bool) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_MANUAL", DbName = "TaskIsManuallyScheduled", DisplayName = "Mode", DataType = typeof(bool) },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_OUTLINE_LEVEL", DbName = "TaskOutlineLevel", DisplayName = "Outline Level", DataType = typeof(int) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_OUTLINE_NUM", DbName = "TaskOutlineNumber", DisplayName = "Outline Number", IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_OVERALLOCATED", DbName = "TaskIsOverallocated", DisplayName = "Overallocated", DataType = typeof(bool), IsUpdatable = false  },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_OVT_COST", DbName = "TaskOvertimeCost", DisplayName = "Overtime Cost", DataType = typeof(decimal), IsUpdatable = false  },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_OVT_WORK", DbName = "TaskOvertimeWork", DisplayName = "Overtime Work", DataType = typeof(decimal), IsUpdatable = false  },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_PHY_PCT_COMP", DbName = "TaskPhysicalPercentCompleted", DisplayName = "Physical % Complete", DataType = typeof(decimal) },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_PRIORITY", DbName = "TaskPriority", DisplayName = "Priority", DataType = typeof(int) },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_RECURRING", DbName = "TaskIsRecurring", DisplayName = "Recurring", DataType = typeof(bool), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_REG_WORK", DbName = "TaskRegularWork", DisplayName = "Regular Work", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_REM_COST", DbName = "TaskemainingCost", DisplayName = "Remaining Cost", DataType = typeof(decimal), IsUpdatable = false},//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_REM_DUR", DbName = "TaskRemainingDuration", DisplayName = "Remaining Duration", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_REM_OVT_COST", DbName = "TaskRemainingOvertimeCost", DisplayName = "Remaining Overtime Cost", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_REM_OVT_WORK", DbName = "TaskRemainingOvertimeWork", DisplayName = "Remaining Overtime Work", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_REM_WORK", DbName = "TaskRemainingWork", DisplayName = "Remaining Work", DataType = typeof(decimal) },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_SPI", DbName = "TaskSPI", DisplayName = "SPI", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_START_DATE", DbName = "TaskStartDate", DisplayName = "Start", DataType = typeof(DateTime) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_START_VAR", DbName = "TaskStartVariance", DisplayName = "Start Variance", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_IS_SUMMARY", DbName = "TaskIsSummary", DisplayName = "Summary", DataType = typeof(bool), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_SV", DbName = "TaskSV", DisplayName = "SV", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TaskSVP", DbName = "TaskSVP", DisplayName = "SVP", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_DUR_TXT", DbName = "TaskDurationString", DisplayName = "Task Duration Text" },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_FINISH_TXT", DbName = "TaskFinishDateText", DisplayName = "Task Finish Text" },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_NAME", DbName = "TaskName", DisplayName = "Task Name", IsUpdatable = false }, //not sure why
            new PsFieldInfo { TableName = "Task", PsName = "TASK_START_TXT", DbName = "TaskStartDateText", DisplayName = "Task Start Text" },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_TCPI", DbName = "TaskTCPI", DisplayName = "TCPI", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_TOTAL_SLACK", DbName = "TaskTotalSlack", DisplayName = "Total Slack", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_VAC", DbName = "TaskVAC", DisplayName = "VAC", DataType = typeof(decimal), IsUpdatable = false },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_WBS", DbName = "TaskWBS", DisplayName = "WBS" },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_WORK", DbName = "TaskWork", DisplayName = "Work", DataType = typeof(decimal) },//
			new PsFieldInfo { TableName = "Task", PsName = "TASK_WORK_VAR", DbName = "TaskWorkVariance", DisplayName = "Work Variance", DataType = typeof(decimal), IsUpdatable = false },//
            new PsFieldInfo { TableName = "Task", PsName = "TASK_UID", DbName = "TaskUID", DisplayName = "Task ID", DataType = typeof(Guid), IsUpdatable = false },//
            
            //new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_CONSTRAINT_DATE", Title = "Constraint Date", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_CONSTRAINT_TYPE", Title = "Constraint Type" },
            //new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_CONTACT", Title = "Contact" },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_TYPE", Title = "Type" },
            //new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_STOP_DATE", Title = "Stop", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_IS_READONLY_SUBPROJ", Title = "Subproject Read Only", DataType = typeof(bool) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_START_SLACK", Title = "Start Slack" },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_RESUME_DATE", Title = "Resume", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_IS_ROLLED_UP", Title = "Rollup", DataType = typeof(bool) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_SCHED_DUR", Title = "Scheduled Duration", DataType = typeof(decimal) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_SCHED_FINISH", Title = "Scheduled Finish", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_SCHED_START", Title = "Scheduled Start", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_PRELEVELED_FINISH", Title = "Preleveled Finish", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_PRELEVELED_START", Title = "Preleveled Start", DataType = typeof(DateTime) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_EVMETHOD", Title = "Earned Value Method" },
            //new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_FINISH_SLACK", Title = "Finish Slack" },
            //new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_FIXED_COST_ACCRUAL", Title = "Fixed Cost Accrual", DataType = typeof(decimal) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_LEVELING_ADJUSTS_ASSN", Title = "Level Assignments" },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_LEVELING_CAN_SPLIT", Title = "Leveling Can Split", DataType = typeof(bool) },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_HAS_LINKED_FIELDS", Title = "Linked Fields" },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "TASK_NOTES", Title = "Notes" },
			//new PsFieldInfo { EntityType = PsEntityType.Task, Column = "PROJ_NAME", Title = "Project Name" },

            new PsFieldInfo { TableName = "Resource", PsName = "RES_BOOKING_TYPE", DbName = "ResourceBookingType", DisplayName = "Booking Type", DataType = typeof(int) },//
			new PsFieldInfo { TableName = "Resource", PsName = "RES_CAN_LEVEL", DbName = "ResourceCanLevel", DisplayName = "Can Level", DataType = typeof(bool) },//
			new PsFieldInfo { TableName = "Resource", PsName = "RES_CODE", DbName = "ResourceCode", DisplayName = "Code" },//
			new PsFieldInfo { TableName = "Resource", PsName = "RES_COST_CENTER", DbName = "ResourceCostCenter", DisplayName = "Cost Center" },//
			new PsFieldInfo { TableName = "Resource", PsName = "CREATED_DATE", DbName = "ResourceCreatedDate", DisplayName = "Resource Created Date", DataType = typeof(DateTime), IsUpdatable = false },
			new PsFieldInfo { TableName = "Resource", PsName = "WRES_EMAIL", DbName = "ResourceEmailAddress", DisplayName = "Email Address" }, //
			new PsFieldInfo { TableName = "Resource", PsName = "RES_GROUP", DbName = "ResourceGroup", DisplayName = "Group" }, //
			new PsFieldInfo { TableName = "Resource", PsName = "RES_HYPERLINK_FRIENDLY_NAME", DbName = "ResourceHyperlink", DisplayName = "Resource Hyperlink" },//
			new PsFieldInfo { TableName = "Resource", PsName = "RES_HYPERLINK_ADDRESS", DbName = "ResourceHyperlinkHref", DisplayName = "Resource Hyperlink Address" },//
			new PsFieldInfo { TableName = "Resource", PsName = "RES_INITIALS", DbName = "ResourceInitials", DisplayName = "Initials" },//
			new PsFieldInfo { TableName = "Resource", PsName = "MOD_DATE", DbName = "ResourceModifiedDate", DisplayName = "Resource Last Modified", DataType = typeof(DateTime), IsUpdatable = false },
			new PsFieldInfo { TableName = "Resource", PsName = "RES_TERMINATION_DATE", DbName = "ResourceLatestAvailableTo", DisplayName = "Latest Available", DataType = typeof(DateTime) },
			new PsFieldInfo { TableName = "Resource", PsName = "RES_MATERIAL_LABEL", DbName = "ResourceMaterialLabel", DisplayName = "Material Label" },
			new PsFieldInfo { TableName = "Resource", PsName = "RES_NAME", DbName = "ResourceName", DisplayName = "Resource Name" },
			new PsFieldInfo { TableName = "Resource", PsName = "RES_TYPE", DbName = "ResourceType", DisplayName = "Resource Type", DataType = typeof(int) },
			new PsFieldInfo { TableName = "Resource", PsName = "RES_IS_TEAM", DbName = "ResourceIsTeam", DisplayName = "Team Assignment Pool", DataType = typeof(bool) },
			new PsFieldInfo { TableName = "Resource", PsName = "RES_UID", DbName = "ResourceUID", DisplayName = "Unique ID", DataType = typeof(Guid), IsUpdatable = false },
			new PsFieldInfo { TableName = "Resource", PsName = "WRES_ACCOUNT", DbName = "ResourceNTAccount", DisplayName = "Windows User Account", IsUpdatable = false },

            //new CustomFieldInfo { EntityType = PsEntityType.Resource, Column = "RES_ACCRUE_AT", Title = "Accrue At" },
			//new CustomFieldInfo { EntityType = PsEntityType.Resource, Column = "RES_HIRE_DATE", Title = "Earliest Available", DataType = typeof(DateTime) },
			//new CustomFieldInfo { EntityType = PsEntityType.Resource, Column = "RES_ID", Title = "ID" },
			//new CustomFieldInfo { EntityType = PsEntityType.Resource, Column = "RES_NOTES", Title = "Notes" },
			//new CustomFieldInfo { EntityType = PsEntityType.Resource, Column = "RES_PHONETICS", Title = "Phonetics" },
			//new CustomFieldInfo { EntityType = PsEntityType.Resource, Column = "RES_EXCHANGE_SYNC", Title = "Synchronize Tasks" },

            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACT_COST", DbName = "AssignmentActualCost", DisplayName = "Assignment Actual Cost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACT_FINISH", DbName = "AssignmentActualFinishDate", DisplayName = "Assignment Actual Finish Date", DataType = typeof(DateTime) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACT_OVT_COST", DbName = "AssignmentActualOvertimeCost", DisplayName = "Assignment Actual Overtime Cost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACT_OVT_WORK", DbName = "AssignmentActualOvertimeWork", DisplayName = "Assignment Actual Overtime Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACT_START", DbName = "AssignmentActualStartDate", DisplayName = "Assignment Actual Start", DataType = typeof(DateTime) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACT_WORK", DbName = "AssignmentActualWork", DisplayName = "Assignment Actual Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_ACWP", DbName = "AssignmentACWP", DisplayName = "Assignment ACWP", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_BCWP", DbName = "AssignmentBCWP", DisplayName = "Assignment BCWP", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_BCWS", DbName = "AssignmentBCWS", DisplayName = "Assignment BCWS", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_BUDGET_COST", DbName = "AssignmentBudgetCost", DisplayName = "Assignment Budget Cost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_BUDGET_WORK", DbName = "AssignmentBudgetWork", DisplayName = "Assignment Budget Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_COST", DbName = "AssignmentCost", DisplayName = "Assignment Cost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_COST_VAR", DbName = "AssignmentCostVariance", DisplayName = "Assignment Cost Variance", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_CV", DbName = "AssignmentCV", DisplayName = "Assignment CV", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_DELAY", DbName = "AssignmentDelay", DisplayName = "Assignment Delay", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_FINISH_DATE", DbName = "AssignmentFinishDate", DisplayName = "Assignment Finish", DataType = typeof(DateTime) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_FINISH_VAR", DbName = "AssignmentFinishVariance", DisplayName = "Assignment Finish Variance", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_IS_OVERALLOCATED", DbName = "AssignmentIsOverallocated", DisplayName = "Assignment Is Overallocated", DataType = typeof(bool) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_IS_PUBLISHED", DbName = "AssignmentIsPublished", DisplayName = "Assignment Is Published", DataType = typeof(bool) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_OVT_COST", DbName = "AssignmentOvertimeCost", DisplayName = "Assignment Overtime Cost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_OVT_WORK", DbName = "AssignmentOvertimeWork", DisplayName = "Assignment Overtime Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_PCT_WORK_COMPLETE", DbName = "AssignmentPercentWorkCompleted", DisplayName = "Assignment % Work Completed", DataType = typeof(int) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_REG_WORK", DbName = "AssignmentRegularWork", DisplayName = "Assignment Regular Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_REM_COST", DbName = "AssignmentRemainingCost", DisplayName = "Assignment Remainin gCost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_REM_OVT_COST", DbName = "AssignmentRemainingOvertimeCost", DisplayName = "Assignment Remaining Overtime Cost", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_REM_OVT_WORK", DbName = "AssignmentRemainingOvertimeWork", DisplayName = "Assignment Remaining Overtime Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_REM_WORK", DbName = "AssignmentRemainingWork", DisplayName = "Assignment Remaining Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_RES_TYPE", DbName = "AssignmentResourceType", DisplayName = "Assignment Resource Type", DataType = typeof(int) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_START_DATE", DbName = "AssignmentStartDate", DisplayName = "Assignment Start", DataType = typeof(DateTime) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_START_VAR", DbName = "AssignmentStartVariance", DisplayName = "Assignment Start Variance", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_SV", DbName = "AssignmentSV", DisplayName = "Assignment SV", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_UID", DbName = "AssignmentUID", DisplayName = "Assignment ID", DataType = typeof(Guid) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_VAC", DbName = "AssignmentVAC", DisplayName = "Assignment VAC", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_WORK", DbName = "AssignmentWork", DisplayName = "Assignment Work", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "ASSN_WORK_VAR", DbName = "AssignmentWorkVariance", DisplayName = "Assignment Work Variance", DataType = typeof(decimal) },
            new PsFieldInfo { TableName = "Assignment", PsName = "CREATED_DATE", DbName = "AssignmentCreatedDate", DisplayName = "Assignment Created Date", DataType = typeof(DateTime) },
            new PsFieldInfo { TableName = "Assignment", PsName = "MOD_DATE", DbName = "AssignmentModifiedDate", DisplayName = "Assignment Modifie dDate", DataType = typeof(DateTime) },
            new PsFieldInfo { TableName = "Assignment", PsName = "PROJ_UID", DbName = "ProjectUID", DisplayName = "Enterprise Project ID", DataType = typeof(Guid) },
            new PsFieldInfo { TableName = "Assignment", PsName = "RES_TYPE", DbName = "AssignmentResourceType", DisplayName = "Assignment Resource Type", DataType = typeof(int) },
            new PsFieldInfo { TableName = "Assignment", PsName = "RES_UID", DbName = "ResourceUID", DisplayName = "Unique ID", DataType = typeof(Guid) },
            new PsFieldInfo { TableName = "Assignment", PsName = "RES_UID_OWNER", DbName = "ResourceOwnerUID", DisplayName = "Resource Owner UID", DataType = typeof(Guid) },
            new PsFieldInfo { TableName = "Assignment", PsName = "TASK_UID", DbName = "TaskUID", DisplayName = "Task ID", DataType = typeof(Guid) },
        };

        public static readonly List<PsFieldInfo> Additional = new List<PsFieldInfo>
        {
            new PsFieldInfo { TableName = "Project", PsName = "WPROJ_DESCRIPTION", DbName = string.Empty, DisplayName = "Description", FieldType = PsFieldType.Intrinsic, ConversionType = PsConversionType.PsStrings, Uid = new Guid("837aafa9-fa1a-49c0-8a08-6b007865991b"), DataType = typeof(string), IsUpdatable = true, Origin = PsOrigin.Manual },
            new PsFieldInfo { TableName = "Resource", PsName = "NEW_RES_UID", DbName = string.Empty, DisplayName = "Resource New Uid", FieldType = PsFieldType.Intrinsic, ConversionType = PsConversionType.Guid, Uid = new Guid("847D3B3A-76A7-469E-8AB1-2BBA6D59D856"), DataType = typeof(Guid), IsUpdatable = true, Origin = PsOrigin.Manual }
        };
    }
}
