/****** Object:  StoredProcedure [dbo].[AMS_Upd_TimesheetDetails]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_TimesheetDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_TimesheetDetails]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_Testcase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_Testcase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_Testcase]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_Password]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_Password]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_Password]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_LeaveCancelation]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_LeaveCancelation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_LeaveCancelation]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompOffStatus]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_CompOffStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_CompOffStatus]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompOffCancelation]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_CompOffCancelation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_CompOffCancelation]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompleteQA]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_CompleteQA]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_CompleteQA]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompLeavesStatus]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_CompLeavesStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_CompLeavesStatus]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_ApproveLeave]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_ApproveLeave]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_ApproveLeave]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_ApproveCompOff]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Upd_ApproveCompOff]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Upd_ApproveCompOff]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_WorkplaceRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_WorkplaceRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_WorkplaceRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_Timesheet]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_Timesheet]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_Timesheet]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_TechnicalRatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_TechnicalRatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_TechnicalRatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfGoals]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_SelfGoals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_SelfGoals]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentTechincalRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_SelfAssessmentTechincalRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentTechincalRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentProjectRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_SelfAssessmentProjectRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentProjectRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentLeadRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_SelfAssessmentLeadRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentLeadRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentGeneralRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_SelfAssessmentGeneralRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentGeneralRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessment]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_SelfAssessment]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_SelfAssessment]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_ProjectRatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_ProjectRatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_ProjectRatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_MGoals]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_MGoals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_MGoals]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeaveReportYearly]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_LeaveReportYearly]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_LeaveReportYearly]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeaveCalendar]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_LeaveCalendar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_LeaveCalendar]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeaveBalance]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_LeaveBalance]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_LeaveBalance]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeadRatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_LeadRatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_LeadRatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_rpt_LeadCommentsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_rpt_LeadCommentsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_rpt_LeadCommentsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_GetLeaveBalance]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_GetLeaveBalance]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_GetLeaveBalance]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_GeneralRatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_GeneralRatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_GeneralRatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_DAssessment]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Rpt_DAssessment]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Rpt_DAssessment]
GO
/****** Object:  StoredProcedure [dbo].[AMS_RoleandDesignations]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_RoleandDesignations]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_RoleandDesignations]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_UpdateLeaveStatus]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_UpdateLeaveStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_UpdateLeaveStatus]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetServiceConfiguration]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_GetServiceConfiguration]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_GetServiceConfiguration]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetMissedTimesheet]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_GetMissedTimesheet]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_GetMissedTimesheet]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetMissedTaskEntry]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_GetMissedTaskEntry]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_GetMissedTaskEntry]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetMissedCompOff]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_GetMissedCompOff]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_GetMissedCompOff]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetLeaveBalance]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_GetLeaveBalance]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_GetLeaveBalance]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_CompOffStatus]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_CompOffStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_CompOffStatus]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_CFLeaves]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Job_CFLeaves]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Job_CFLeaves]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_WorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_WorkType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_WorkType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_WorkPlaceRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_WorkPlaceRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_WorkPlaceRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_UserInfo]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_UserInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_UserInfo]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Testcase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Testcase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Testcase]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_TechnicalRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_TechnicalRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_TechnicalRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Task]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Task]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Task]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_SubTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_SubTask]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_SubTask]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_SelfGoals]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_SelfGoals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_SelfGoals]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_SelectedTestcases]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_SelectedTestcases]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_SelectedTestcases]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Scenario]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Scenario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Scenario]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Requirement]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Requirement]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Requirement]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectWorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_ProjectWorkType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_ProjectWorkType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_ProjectRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_ProjectRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectPhase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_ProjectPhase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_ProjectPhase]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectEmployee]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_ProjectEmployee]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_ProjectEmployee]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Project]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Project]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Project]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_MGoals]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_MGoals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_MGoals]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_LunchLogout]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_LunchLogout]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_LunchLogout]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_LunchLogin]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_LunchLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_LunchLogin]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Leave]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Leave]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Leave]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_LeadRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_LeadRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_LeadRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_INS_Holiday]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_INS_Holiday]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_INS_Holiday]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_GeneralRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_GeneralRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_GeneralRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_FYear]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_FYear]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_FYear]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_EmployeeTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_EmployeeTask]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_EmployeeTask]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_DevBuild]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_DevBuild]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_DevBuild]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_DayLogOut]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_DayLogOut]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_DayLogOut]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_DayLogin]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_DayLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_DayLogin]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Component]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_Component]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_Component]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_CompLeave]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_CompLeave]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_CompLeave]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_BreakLogout]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_BreakLogout]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_BreakLogout]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_BreakLogin]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Ins_BreakLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Ins_BreakLogin]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_WorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_WorkType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_WorkType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_WorkplaceRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_WorkplaceRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_WorkplaceRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UsersforReport]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_UsersforReport]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_UsersforReport]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserPorjects]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_UserPorjects]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_UserPorjects]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserInfo]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_UserInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_UserInfo]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserDetails]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_UserDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_UserDetails]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserCredentials1]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_UserCredentials1]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_UserCredentials1]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_User]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_User]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_User]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TotalHours1]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TotalHours1]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TotalHours1]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TotalHours]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TotalHours]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TotalHours]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TodayHours]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TodayHours]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TodayHours]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TimesheetDetails]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TimesheetDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TimesheetDetails]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Timesheet]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Timesheet]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Timesheet]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestExecutionLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TestExecutionLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TestExecutionLog]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestExecution]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TestExecution]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TestExecution]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestcaseDetails]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TestcaseDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TestcaseDetails]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestcaseDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TestcaseDescription]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TestcaseDescription]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Testcase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Testcase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Testcase]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TechnicalRatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TechnicalRatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TechnicalRatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TechnicalRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TechnicalRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TechnicalRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TaskMaster]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_TaskMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_TaskMaster]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Task]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Task]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Task]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_SubTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_SubTask]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_SubTask]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_SelfGoals]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_SelfGoals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_SelfGoals]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ScenarioForDropDown]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ScenarioForDropDown]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ScenarioForDropDown]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ScenarioDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ScenarioDescription]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ScenarioDescription]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Scenario]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Scenario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Scenario]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Role]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Role]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Role]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_RequirementForDropDown]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_RequirementForDropDown]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_RequirementForDropDown]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_RequirementDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_RequirementDescription]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_RequirementDescription]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Requirement]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Requirement]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Requirement]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ReportingLeads]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ReportingLeads]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ReportingLeads]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ReportingEmployees]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ReportingEmployees]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ReportingEmployees]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_RatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_RatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_RatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectWorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectWorkType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectWorkType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectTask]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectTask]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectsRatingMaster]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectsRatingMaster]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectsRatingMaster]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectRatingsfoMS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectRatingsfoMS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectRatingsfoMS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectRatingsByIDForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectRatingsByIDForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectRatingsByIDForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectRatingsByID]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectRatingsByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectRatingsByID]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectPhase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectPhase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectPhase]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectListForReport]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectListForReport]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectListForReport]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectEmployee]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectEmployee]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectEmployee]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectDetails]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ProjectDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ProjectDetails]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Project]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Project]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Project]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_MGoals]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_MGoals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_MGoals]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LoginState]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LoginState]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LoginState]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LiveHours]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LiveHours]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LiveHours]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeaveType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeaveType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeavesForApproval]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeavesForApproval]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeavesForApproval]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeavePlan]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeavePlan]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeavePlan]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveHistoryForLead]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeaveHistoryForLead]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeaveHistoryForLead]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveHistory]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeaveHistory]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeaveHistory]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveDuration]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeaveDuration]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeaveDuration]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveDetailsByID]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeaveDetailsByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeaveDetailsByID]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadRatingsForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeadRatingsForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeadRatingsForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeadRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeadRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadDetailsForCompOffMail]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeadDetailsForCompOffMail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeadDetailsForCompOffMail]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadDetails]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_LeadDetails]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_LeadDetails]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_HolidayType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_HolidayType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_HolidayType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_HoliDay]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_HoliDay]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_HoliDay]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_GeneralRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_GeneralRatings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_GeneralRatings]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_FYear]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_FYear]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_FYear]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_FinalRatingWithLR]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_FinalRatingWithLR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_FinalRatingWithLR]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_FinalRating]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_FinalRating]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_FinalRating]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeTaskForLead]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeTaskForLead]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeTaskForLead]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeTaskByID]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeTaskByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeTaskByID]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeTaks]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeTaks]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeTaks]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeListForLeaveApproval]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeListForLeaveApproval]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeListForLeaveApproval]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeList]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeList]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeforProjectRating]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeforProjectRating]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeforProjectRating]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeforLRating]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeforLRating]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeforLRating]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeforGR]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeforGR]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeforGR]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeForDS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeForDS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeForDS]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeDetialsByID]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_EmployeeDetialsByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_EmployeeDetialsByID]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DevBuildForQA]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_DevBuildForQA]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_DevBuildForQA]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DevBuild]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_DevBuild]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_DevBuild]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Designation]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Designation]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Designation]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DeatailsByType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_DeatailsByType]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_DeatailsByType]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DayBreaksByID]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_DayBreaksByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_DayBreaksByID]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DayBreaks]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_DayBreaks]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_DayBreaks]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Dashboard]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Dashboard]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Dashboard]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ComponentForDropDown]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ComponentForDropDown]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ComponentForDropDown]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ComponentDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_ComponentDescription]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_ComponentDescription]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Component]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_Component]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_Component]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOffForLead]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_CompOffForLead]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_CompOffForLead]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOffForApporval]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_CompOffForApporval]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_CompOffForApporval]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOffDetailsByID]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_CompOffDetailsByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_CompOffDetailsByID]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOff]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_CompOff]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_CompOff]
GO
/****** Object:  StoredProcedure [dbo].[AMS_GeT_ChangeLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GeT_ChangeLog]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_GeT_ChangeLog]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_AssessmentMode]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Get_AssessmentMode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Get_AssessmentMode]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_UserInfo]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_UserInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_UserInfo]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_ProjectPhase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_ProjectPhase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_ProjectPhase]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_ProjectEmployeeMap]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_ProjectEmployeeMap]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_ProjectEmployeeMap]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_Project]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_Project]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_Project]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_Holiday]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_Holiday]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_Holiday]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_EmployeeTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_EmployeeTask]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_EmployeeTask]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_Component]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Del_Component]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Del_Component]
GO
/****** Object:  StoredProcedure [dbo].[AMS_Check_DBVersion]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Check_DBVersion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_Check_DBVersion]
GO
/****** Object:  StoredProcedure [dbo].[AMS_AYearandUserforMS]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_AYearandUserforMS]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AMS_AYearandUserforMS]
GO
/****** Object:  Table [dbo].[test]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[test]') AND type in (N'U'))
DROP TABLE [dbo].[test]
GO
/****** Object:  Table [dbo].[AMS_WorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_WorkType]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_WorkType]
GO
/****** Object:  Table [dbo].[AMS_WorkPlaceRatingsMap]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_WorkPlaceRatingsMap]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_WorkPlaceRatingsMap]
GO
/****** Object:  Table [dbo].[AMS_WorkPlaceRatingsComments]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_WorkPlaceRatingsComments]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_WorkPlaceRatingsComments]
GO
/****** Object:  Table [dbo].[AMS_WorkPlaceRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_WorkPlaceRatings]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_WorkPlaceRatings]
GO
/****** Object:  Table [dbo].[AMS_UserInfo]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_UserInfo]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_UserInfo]
GO
/****** Object:  Table [dbo].[AMS_TimeSheet]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TimeSheet]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TimeSheet]
GO
/****** Object:  Table [dbo].[AMS_TestExecutionLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TestExecutionLog]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TestExecutionLog]
GO
/****** Object:  Table [dbo].[AMS_TestExecution]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TestExecution]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TestExecution]
GO
/****** Object:  Table [dbo].[AMS_TestcaseLogDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TestcaseLogDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TestcaseLogDescription]
GO
/****** Object:  Table [dbo].[AMS_TestcaseLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TestcaseLog]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TestcaseLog]
GO
/****** Object:  Table [dbo].[AMS_TestcaseDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TestcaseDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TestcaseDescription]
GO
/****** Object:  Table [dbo].[AMS_Testcase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Testcase]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Testcase]
GO
/****** Object:  Table [dbo].[AMS_TechnicalRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TechnicalRatings]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TechnicalRatings]
GO
/****** Object:  Table [dbo].[AMS_TechnicalPerformance]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_TechnicalPerformance]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_TechnicalPerformance]
GO
/****** Object:  Table [dbo].[AMS_Task]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Task]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Task]
GO
/****** Object:  Table [dbo].[AMS_SubTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_SubTask]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_SubTask]
GO
/****** Object:  Table [dbo].[AMS_ScenarioLogDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ScenarioLogDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ScenarioLogDescription]
GO
/****** Object:  Table [dbo].[AMS_ScenarioLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ScenarioLog]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ScenarioLog]
GO
/****** Object:  Table [dbo].[AMS_ScenarioDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ScenarioDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ScenarioDescription]
GO
/****** Object:  Table [dbo].[AMS_Scenario]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Scenario]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Scenario]
GO
/****** Object:  Table [dbo].[AMS_Role]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Role]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Role]
GO
/****** Object:  Table [dbo].[AMS_RequirementLogDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_RequirementLogDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_RequirementLogDescription]
GO
/****** Object:  Table [dbo].[AMS_RequirementLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_RequirementLog]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_RequirementLog]
GO
/****** Object:  Table [dbo].[AMS_RequirementFile]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_RequirementFile]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_RequirementFile]
GO
/****** Object:  Table [dbo].[AMS_RequirementDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_RequirementDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_RequirementDescription]
GO
/****** Object:  Table [dbo].[AMS_Requirement]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Requirement]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Requirement]
GO
/****** Object:  Table [dbo].[AMS_ProjectWorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ProjectWorkType]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ProjectWorkType]
GO
/****** Object:  Table [dbo].[AMS_ProjectUserMap]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ProjectUserMap]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ProjectUserMap]
GO
/****** Object:  Table [dbo].[AMS_Projects]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Projects]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Projects]
GO
/****** Object:  Table [dbo].[AMS_ProjectPhase]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ProjectPhase]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ProjectPhase]
GO
/****** Object:  Table [dbo].[AMS_ProjectEmployee]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ProjectEmployee]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ProjectEmployee]
GO
/****** Object:  Table [dbo].[AMS_ProjectCriteriaMap]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ProjectCriteriaMap]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ProjectCriteriaMap]
GO
/****** Object:  Table [dbo].[AMS_Lookup]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Lookup]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Lookup]
GO
/****** Object:  Table [dbo].[AMS_LeaveType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_LeaveType]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_LeaveType]
GO
/****** Object:  Table [dbo].[AMS_LeaveStatus]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_LeaveStatus]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_LeaveStatus]
GO
/****** Object:  Table [dbo].[AMS_LeaveCF]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_LeaveCF]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_LeaveCF]
GO
/****** Object:  Table [dbo].[AMS_LeaveApproval]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_LeaveApproval]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_LeaveApproval]
GO
/****** Object:  Table [dbo].[AMS_LeadRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_LeadRatings]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_LeadRatings]
GO
/****** Object:  Table [dbo].[AMS_LeadPerformance]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_LeadPerformance]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_LeadPerformance]
GO
/****** Object:  Table [dbo].[AMS_HoliDay]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_HoliDay]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_HoliDay]
GO
/****** Object:  Table [dbo].[AMS_GeneralPerformance]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GeneralPerformance]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_GeneralPerformance]
GO
/****** Object:  Table [dbo].[AMS_GenaralRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GenaralRatings]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_GenaralRatings]
GO
/****** Object:  Table [dbo].[AMS_FYear]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_FYear]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_FYear]
GO
/****** Object:  Table [dbo].[AMS_EmployeeTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_EmployeeTask]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_EmployeeTask]
GO
/****** Object:  Table [dbo].[AMS_EmployeeLeave]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_EmployeeLeave]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_EmployeeLeave]
GO
/****** Object:  Table [dbo].[AMS_DevlogDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_DevlogDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_DevlogDescription]
GO
/****** Object:  Table [dbo].[AMS_DevBuildLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_DevBuildLog]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_DevBuildLog]
GO
/****** Object:  Table [dbo].[AMS_DevBuild]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_DevBuild]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_DevBuild]
GO
/****** Object:  Table [dbo].[AMS_Designation]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Designation]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Designation]
GO
/****** Object:  Table [dbo].[AMS_DayBreak]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_DayBreak]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_DayBreak]
GO
/****** Object:  Table [dbo].[AMS_Criteria]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Criteria]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Criteria]
GO
/****** Object:  Table [dbo].[AMS_ComponentLogDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ComponentLogDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ComponentLogDescription]
GO
/****** Object:  Table [dbo].[AMS_ComponentLog]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ComponentLog]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ComponentLog]
GO
/****** Object:  Table [dbo].[AMS_ComponentDescription]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_ComponentDescription]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_ComponentDescription]
GO
/****** Object:  Table [dbo].[AMS_Component]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_Component]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_Component]
GO
/****** Object:  Table [dbo].[AMS_CompensatoryLeaveApproval]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_CompensatoryLeaveApproval]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_CompensatoryLeaveApproval]
GO
/****** Object:  Table [dbo].[AMS_CompensatoryLeave]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_CompensatoryLeave]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_CompensatoryLeave]
GO
/****** Object:  Table [dbo].[AMS_AssessmentYear]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_AssessmentYear]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_AssessmentYear]
GO
/****** Object:  Table [dbo].[AMS_AssessmentMode]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_AssessmentMode]') AND type in (N'U'))
DROP TABLE [dbo].[AMS_AssessmentMode]
GO
/****** Object:  UserDefinedFunction [dbo].[WorkType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[WorkType]
GO
/****** Object:  UserDefinedFunction [dbo].[SubTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubTask]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[SubTask]
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SplitString]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[SplitString]
GO
/****** Object:  UserDefinedFunction [dbo].[LDOMonth]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LDOMonth]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[LDOMonth]
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetUTCDate]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GetUTCDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[AMS_GetUTCDate]
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetLocalDate]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GetLocalDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[AMS_GetLocalDate]
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetLeaveDetailsByType]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GetLeaveDetailsByType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[AMS_GetLeaveDetailsByType]
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetHours]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AMS_GetHours]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[AMS_GetHours]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_StImage]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_StImage' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_StImage]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_Ints]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_Ints' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_Ints]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtWorkplaceRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_dtWorkplaceRatings' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_dtWorkplaceRatings]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtPorjectRatings1]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_dtPorjectRatings1' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_dtPorjectRatings1]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtPorjectRatings]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_dtPorjectRatings' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_dtPorjectRatings]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtEmployeeTask]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_dtEmployeeTask' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_dtEmployeeTask]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtBreaks]    Script Date: 06-04-2021 15:26:06 ******/
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'AMS_dtBreaks' AND ss.name = N'dbo')
DROP TYPE [dbo].[AMS_dtBreaks]
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtBreaks]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_dtBreaks] AS TABLE(
	[DayBreakID] [int] NULL,
	[BreakLogin] [datetime] NULL,
	[BreakLogout] [datetime] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtEmployeeTask]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_dtEmployeeTask] AS TABLE(
	[TaskID] [int] NULL,
	[SubTaskID] [int] NULL,
	[WorktypeID] [int] NULL,
	[TaskHours] [int] NULL,
	[TaskDescription] [nvarchar](500) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtPorjectRatings]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_dtPorjectRatings] AS TABLE(
	[CriteriaID] [int] NULL,
	[Rating] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtPorjectRatings1]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_dtPorjectRatings1] AS TABLE(
	[CriteriaID] [int] NULL,
	[Rating] [decimal](18, 2) NULL,
	[Comments] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_dtWorkplaceRatings]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_dtWorkplaceRatings] AS TABLE(
	[WorkPlaceRatingsID] [int] NULL,
	[RatingsDescription] [nvarchar](100) NULL,
	[Rating] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_Ints]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_Ints] AS TABLE(
	[ID] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[AMS_StImage]    Script Date: 06-04-2021 15:26:06 ******/
CREATE TYPE [dbo].[AMS_StImage] AS TABLE(
	[StudentID] [int] NULL,
	[ImageData] [image] NULL,
	[UserID] [int] NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetHours]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AMS_GetHours]  
(      
@TotalMins int  
)  
RETURNS nvarchar(50)  
AS  
BEGIN  
  
declare @Output nvarchar(50)  

if (LEN(Cast(@TotalMins / 60 as Varchar)) <=2)
begin
set @Output = (REPLICATE('0',2- LEN(Cast(@TotalMins / 60 as Varchar))) + Cast(@TotalMins / 60 as Varchar)) + ':' +    
(REPLICATE('0',2-LEN(Cast(@TotalMins % 60 as Varchar))) + Cast(@TotalMins % 60 as Varchar))  
end
else
begin
set @Output = (Cast(@TotalMins / 60 as Varchar)) + ':' +    
(REPLICATE('0',2-LEN(Cast(@TotalMins % 60 as Varchar))) + Cast(@TotalMins % 60 as Varchar))  
end

  
RETURN @Output  
END  
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetLeaveDetailsByType]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AMS_GetLeaveDetailsByType]  
(  
@LeaveTypeID int,  
@FYearID int,  
@EmployeeID int  
)  
RETURNS @Output TABLE (  
TotalLeaves DECIMAL(10,2),ProRataLeaves DECIMAL(10,2),  
LeavesAvailed DECIMAL(10,2),LeaveBalance DECIMAL(10,2)  
)  
AS  
BEGIN  

declare @Fromdate date,@Todate date,@JoiningDate Date
select @Fromdate = FromDate,@Todate = DBO.LDOMonth(ToDate) from AMS_FYear where FYearID = @FYearID  
select @JoiningDate = JoingDate from AMS_UserInfo where UserInfoID = @EmployeeID  

declare @TotalLeaves decimal(10,2),@ProrataLeaves decimal(10,2),  
@LeavesAvailed decimal(10,2),@LeaveBalance decimal(10,2)  
  
DECLARE @CFLeaves decimal(10,2) = 0  
select @CFLeaves = ISNULL(Quantity,0) from AMS_LeaveCF where FYearID = @FYearID  
and EmployeeID = @EmployeeID  
  
declare @CompLeaves decimal(10,2) = 0  
if(@LeaveTypeID = 4)  
select @CompLeaves = ISNULL(SUM(LeaveDays - AvailedDays ),0) from AMS_CompensatoryLeave  
where EmployeeID = @EmployeeID and LeaveStatus IN (1,7)  
  
select @TotalLeaves =  
case when @ToDate < @JoiningDate  then 0 else    
case when @LeaveTypeID = 1 then ISNULL(@CFLeaves,0) +                          
DATEDIFF(MONTH, CASE WHEN @Fromdate < @JoiningDate THEN @JoiningDate ELSE @Fromdate END,@Todate) + 1    
when @LeaveTypeID = 2 or @LeaveTypeID = 3 then                          
CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < @JoiningDate THEN     
@JoiningDate ELSE @Fromdate END,@Todate) + 1 as decimal(10,2))/2                          
else 0 end end

select @ProrataLeaves =  
case when @ToDate < @JoiningDate then 0 else    
case when @LeaveTypeID = 1                          
then ISNULL(@CFLeaves,0) + DATEDIFF(Month,CASE WHEN @Fromdate < @JoiningDate THEN @JoiningDate ELSE @Fromdate END    
,CASE WHEN @Todate < dbo.AMS_GetLocalDate(GETUTCDATE()) then @Todate else dbo.AMS_GetLocalDate(GETUTCDATE()) end) + 1    
when @LeaveTypeID = 2    
then CAST(DATEDIFF(Month,CASE WHEN @Fromdate < @JoiningDate THEN @JoiningDate ELSE @Fromdate END,    
CASE WHEN @Todate < dbo.AMS_GetLocalDate(GETUTCDATE()) then @Todate else 
dbo.AMS_GetLocalDate(GETUTCDATE()) end)+1 as decimal(10,2))/2    
when @LeaveTypeID = 3 then CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < @JoiningDate THEN @JoiningDate ELSE @Fromdate END,    
@Todate) + 1 as decimal(10,2))/2                          
else 0 end end
  
select @LeavesAvailed = ISNULL(SUM(LeaveDays),0) from AMS_EmployeeLeave  
where FYearID = @FYearID and LeaveTypeID = @LeaveTypeID  
and EmployeeID = @EmployeeID and (LeaveStatusID = 1 OR LeaveStatusID = 4 OR LeaveStatusID = 5)  
  
if(@LeaveTypeID = 1 Or @LeaveTypeID = 2 Or @LeaveTypeID = 3)  
begin  
Set @LeaveBalance = @ProrataLeaves - @LeavesAvailed  
end  
else if(@LeaveTypeID = 4)  
begin  
Set @LeaveBalance = @CompLeaves  
end  
else  
begin  
Set @LeaveBalance = 0  
end  
  
INSERT INTO @Output(TotalLeaves,ProRataLeaves,LeavesAvailed,LeaveBalance)  
VALUES(@TotalLeaves,@ProrataLeaves,@LeavesAvailed,@LeaveBalance)  
  
RETURN  
END
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetLocalDate]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[AMS_GetLocalDate]
(    
      @date datetime
)
RETURNS datetime
AS
BEGIN

declare @Output datetime
set @Output = DATEADD(minute, 330, @date)

RETURN @Output
END
GO
/****** Object:  UserDefinedFunction [dbo].[AMS_GetUTCDate]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[AMS_GetUTCDate]
(    
      @date datetime
)
RETURNS datetime
AS
BEGIN

declare @Output datetime
set @Output = DATEADD(minute, -330, @date)

RETURN @Output
END
GO
/****** Object:  UserDefinedFunction [dbo].[LDOMonth]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LDOMonth]
(    
      @Date DATETIME
)
RETURNS DATE
AS
BEGIN
      DECLARE @Output DATE
	  SET @Output = DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,@Date)+1,0))
RETURN @Output
END
GO
/****** Object:  UserDefinedFunction [dbo].[SplitString]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SplitString]
(    
      @Input NVARCHAR(MAX),
      @Character CHAR(1)
)
RETURNS @Output TABLE (
      Item NVARCHAR(1000)
)
AS
BEGIN
      DECLARE @StartIndex INT, @EndIndex INT
      SET @StartIndex = 1
      IF SUBSTRING(@Input, LEN(@Input) - 1, LEN(@Input)) <> @Character
      BEGIN
            SET @Input = @Input + @Character
      END
      WHILE CHARINDEX(@Character, @Input) > 0
      BEGIN
            SET @EndIndex = CHARINDEX(@Character, @Input)
           
            INSERT INTO @Output(Item)
            SELECT SUBSTRING(@Input, @StartIndex, @EndIndex - 1)
           
            SET @Input = SUBSTRING(@Input, @EndIndex + 1, LEN(@Input))
      END
      RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[SubTask]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SubTask]()  
RETURNS @Output     
TABLE (    
SubTaskID int,SubTaskDescription nvarchar(100),TaskID int)    
AS    
BEGIN    
  
insert into @Output          
select SubTaskID,SubTaskDescription,TaskID from AMS_SubTask          
insert into @Output          
select ProjectID,ProjectName,5 from AMS_Projects where ISNULL(IsActive,0) = 1
    
RETURN    
END  
GO
/****** Object:  UserDefinedFunction [dbo].[WorkType]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[WorkType]()
RETURNS @Output   
TABLE (WorkTypeID int,WorkTypedescription nvarchar(100),SubTaskID int)
AS  
BEGIN  

insert into @Output        
SELECT WorkTypeID,WorkTypedescription,SubTaskID FROM AMS_WorkType              
        
INSERT INTO @Output        
SELECT ProjectWorkTypeID,WorkTypeDescription,ProjectID FROM AMS_Projects, AMS_ProjectWorkType        
  
RETURN  
END
GO
/****** Object:  Table [dbo].[AMS_AssessmentMode]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_AssessmentMode](
	[AssessmentModeID] [int] IDENTITY(1,1) NOT NULL,
	[AssessmentModeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_AssessmentMode] PRIMARY KEY CLUSTERED 
(
	[AssessmentModeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_AssessmentYear]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_AssessmentYear](
	[AssessmentYearID] [int] IDENTITY(1,1) NOT NULL,
	[AssessmentYearName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_AssessmentYear] PRIMARY KEY CLUSTERED 
(
	[AssessmentYearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_CompensatoryLeave]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_CompensatoryLeave](
	[CompensatoryLeaveID] [int] IDENTITY(1,1) NOT NULL,
	[LeaveDate] [date] NULL,
	[LeaveStatus] [int] NULL,
	[LeaveReason] [nvarchar](500) NULL,
	[EmployeeID] [int] NULL,
	[leavedays] [decimal](10, 2) NULL,
	[LeaveDurationID] [int] NULL,
	[AvailedDays] [decimal](18, 2) NULL,
	[StatusChangeComments] [nvarchar](4000) NULL,
	[Availeddate] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_CompensatoryLeaveApproval]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_CompensatoryLeaveApproval](
	[CompensatoryLeaveApprovalID] [int] IDENTITY(1,1) NOT NULL,
	[LeadID] [int] NULL,
	[IsApproved] [bit] NULL,
	[ApporvedDate] [date] NULL,
	[CompensatoryLeaveID] [int] NULL,
	[ApprovalStatus] [int] NULL,
 CONSTRAINT [PK_AMS_CompensatoryLeaveApproval] PRIMARY KEY CLUSTERED 
(
	[CompensatoryLeaveApprovalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Component]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Component](
	[ComponentID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectPhaseID] [int] NULL,
	[ComponentName] [nvarchar](500) NULL,
	[Status] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdatedBy] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_AMS_ProjectComponent] PRIMARY KEY CLUSTERED 
(
	[ComponentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ComponentDescription]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ComponentDescription](
	[ComponentDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentID] [int] NULL,
	[ComponentDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_ComponentDescription] PRIMARY KEY CLUSTERED 
(
	[ComponentDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ComponentLog]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ComponentLog](
	[ComponentLogID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentID] [int] NULL,
	[LogCreatedBy] [int] NULL,
	[LogCreatedDate] [datetime] NULL,
	[LogType] [int] NULL,
 CONSTRAINT [PK_AMS_ComponentLog] PRIMARY KEY CLUSTERED 
(
	[ComponentLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ComponentLogDescription]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ComponentLogDescription](
	[ComponentLogDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentLogID] [int] NULL,
	[ComponentDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_ComponentLogDescription] PRIMARY KEY CLUSTERED 
(
	[ComponentLogDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Criteria]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Criteria](
	[CriteriaID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](2000) NULL,
	[CriteriaName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_Criteria] PRIMARY KEY CLUSTERED 
(
	[CriteriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_DayBreak]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_DayBreak](
	[DayBreakID] [int] IDENTITY(1,1) NOT NULL,
	[TimesheetID] [int] NULL,
	[BreakLogin] [datetime] NULL,
	[BreakLogout] [datetime] NULL,
	[EmployeeID] [int] NULL,
	[BreakMins] [int] NULL,
 CONSTRAINT [PK_AMS_DayBreak] PRIMARY KEY CLUSTERED 
(
	[DayBreakID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Designation]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Designation](
	[DesignationID] [int] IDENTITY(1,1) NOT NULL,
	[DesignationName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_Role] PRIMARY KEY CLUSTERED 
(
	[DesignationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_DevBuild]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_DevBuild](
	[DevBuildID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectPhaseID] [int] NULL,
	[ProjectID] [int] NULL,
	[BuildVersion] [nvarchar](50) NULL,
	[BuildPath] [nvarchar](500) NULL,
	[ImpactAnalysis] [nvarchar](2000) NULL,
	[ImpactModules] [nvarchar](2000) NULL,
	[BuildChanges] [nvarchar](2000) NULL,
	[QAComments] [nvarchar](2000) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[LastupdatedBy] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[BuildStatus] [int] NULL,
 CONSTRAINT [PK_AMS_DevBuild] PRIMARY KEY CLUSTERED 
(
	[DevBuildID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_DevBuildLog]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_DevBuildLog](
	[DevBuildLogID] [int] IDENTITY(1,1) NOT NULL,
	[DevBuildID] [int] NULL,
	[LogCreatedBy] [int] NULL,
	[LogCreatedDate] [datetime] NULL,
	[LogType] [int] NULL,
 CONSTRAINT [PK_AMS_DevBuildLog] PRIMARY KEY CLUSTERED 
(
	[DevBuildLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_DevlogDescription]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_DevlogDescription](
	[DevlogDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[DevBuildLogID] [int] NULL,
	[BuildVersion] [nvarchar](50) NULL,
	[BuildPath] [nvarchar](500) NULL,
	[ImpactAnalysis] [nvarchar](2000) NULL,
	[ImpactModules] [nvarchar](2000) NULL,
	[BuildChanges] [nvarchar](2000) NULL,
	[QAComments] [nvarchar](2000) NULL,
	[BuildStatus] [int] NULL,
 CONSTRAINT [PK_AMS_DevlogDescription] PRIMARY KEY CLUSTERED 
(
	[DevlogDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_EmployeeLeave]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_EmployeeLeave](
	[EmployeeLeaveID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[LeaveTypeID] [int] NULL,
	[LeaveFromDate] [date] NULL,
	[LeaveToDate] [date] NULL,
	[LeaveReason] [nvarchar](1000) NULL,
	[IsProjectDelivery] [bit] NULL,
	[IsCompleted] [bit] NULL,
	[ProjectPlan] [nvarchar](1000) NULL,
	[EmergencyContact] [nvarchar](500) NULL,
	[LeaveDays] [decimal](10, 2) NULL,
	[LeaveStatusID] [int] NULL,
	[FYearID] [int] NULL,
	[LeaveCategoryID] [int] NULL,
	[LeaveDurationID] [int] NULL,
 CONSTRAINT [PK_H_EmployeeLeave] PRIMARY KEY CLUSTERED 
(
	[EmployeeLeaveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_EmployeeTask]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_EmployeeTask](
	[EmployeeTaskID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[TaskID] [int] NULL,
	[SubTaskID] [int] NULL,
	[WorkTypeID] [int] NULL,
	[TaskHours] [int] NULL,
	[TaskDescription] [nvarchar](500) NULL,
	[TimesheetID] [int] NULL,
 CONSTRAINT [PK_AMS_EmployeeTask] PRIMARY KEY CLUSTERED 
(
	[EmployeeTaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_FYear]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_FYear](
	[FYearID] [int] IDENTITY(1,1) NOT NULL,
	[FYearName] [nvarchar](50) NULL,
	[FromDate] [date] NULL,
	[ToDate] [date] NULL,
	[EnableAssessment] [bit] NULL,
 CONSTRAINT [PK_AMS_FYear] PRIMARY KEY CLUSTERED 
(
	[FYearID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_GenaralRatings]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_GenaralRatings](
	[GenaralRatingsID] [int] IDENTITY(1,1) NOT NULL,
	[UserInfoID] [int] NULL,
	[Rating] [decimal](18, 2) NULL,
	[GeneralPerformanceID] [int] NULL,
	[AssessmentYearID] [int] NULL,
	[RatingUserID] [int] NULL,
	[AssessmentModeID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_GeneralPerformance]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_GeneralPerformance](
	[GeneralPerformanceID] [int] IDENTITY(1,1) NOT NULL,
	[RatingName] [nvarchar](500) NULL,
	[RatingDescription] [nvarchar](3000) NULL,
	[ISCRM] [bit] NULL,
	[IsEmployee] [bit] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[GeneralPerformanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_HoliDay]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_HoliDay](
	[HolidayID] [int] IDENTITY(1,1) NOT NULL,
	[HolidayDate] [date] NULL,
	[HolidayName] [nvarchar](500) NULL,
	[CategoryID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DayID] [int] NULL,
 CONSTRAINT [PK_AMS_HoliDay] PRIMARY KEY CLUSTERED 
(
	[HolidayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_LeadPerformance]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_LeadPerformance](
	[LeadPerformanceID] [int] IDENTITY(1,1) NOT NULL,
	[RatingName] [nvarchar](500) NULL,
	[RatingDescription] [nvarchar](3000) NULL,
 CONSTRAINT [PK_LeadPerformanceID] PRIMARY KEY CLUSTERED 
(
	[LeadPerformanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_LeadRatings]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_LeadRatings](
	[LeadRatingsID] [int] IDENTITY(1,1) NOT NULL,
	[UserInfoID] [int] NULL,
	[Rating] [decimal](18, 2) NULL,
	[LeadPerformanceID] [int] NULL,
	[AssessmentYearID] [int] NULL,
	[RatingUserID] [int] NULL,
	[Comments] [nvarchar](max) NULL,
	[AssessmentModeID] [int] NULL,
 CONSTRAINT [PK_AMS_LeadRatingsID] PRIMARY KEY CLUSTERED 
(
	[LeadRatingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_LeaveApproval]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_LeaveApproval](
	[LeaveApprovalID] [int] IDENTITY(1,1) NOT NULL,
	[EmoloyeeLeaveID] [int] NULL,
	[LeadID] [int] NULL,
	[LeadComments] [nvarchar](1000) NULL,
	[IsApproved] [bit] NULL,
	[ApprovalDate] [date] NULL,
	[ApprovalStatus] [int] NULL,
 CONSTRAINT [PK_H_LeaveApproval] PRIMARY KEY CLUSTERED 
(
	[LeaveApprovalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_LeaveCF]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_LeaveCF](
	[LeaveCFID] [int] IDENTITY(1,1) NOT NULL,
	[FYearID] [int] NULL,
	[LeaveTypeID] [int] NULL,
	[Quantity] [decimal](10, 2) NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_AMS_LeaveCF] PRIMARY KEY CLUSTERED 
(
	[LeaveCFID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_LeaveStatus]    Script Date: 06-04-2021 15:26:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_LeaveStatus](
	[LeaveStatusID] [int] IDENTITY(1,1) NOT NULL,
	[LeaveStatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_LeaveStatus] PRIMARY KEY CLUSTERED 
(
	[LeaveStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_LeaveType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_LeaveType](
	[LeaveTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LeaveTypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_LeaveType] PRIMARY KEY CLUSTERED 
(
	[LeaveTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Lookup]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Lookup](
	[LookupID] [int] IDENTITY(1,1) NOT NULL,
	[LookupValue] [nvarchar](100) NULL,
	[MapID] [int] NULL,
	[LookupDescription] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ProjectCriteriaMap]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ProjectCriteriaMap](
	[ProjectCriteriaMapID] [int] IDENTITY(1,1) NOT NULL,
	[CriteriaID] [int] NULL,
	[ProjectUserMapID] [int] NULL,
	[UserInfoID] [int] NULL,
	[RatingPercentage] [decimal](18, 2) NULL,
	[Rating] [decimal](18, 2) NULL,
	[Comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_ProjectCriteriaMap] PRIMARY KEY CLUSTERED 
(
	[ProjectCriteriaMapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ProjectEmployee]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ProjectEmployee](
	[ProjectEmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NULL,
	[ProjectPhaseID] [int] NULL,
	[EmployeeID] [int] NULL,
	[JoiningDate] [date] NULL,
	[RelievingDate] [date] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_AMS_ProjectEmployee] PRIMARY KEY CLUSTERED 
(
	[ProjectEmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ProjectPhase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ProjectPhase](
	[ProjectPhaseID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NULL,
	[PhaseName] [nvarchar](500) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AMS_ProjectPhase] PRIMARY KEY CLUSTERED 
(
	[ProjectPhaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Projects]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Projects](
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](500) NULL,
	[ProjectLeadID] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AMS_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ProjectUserMap]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ProjectUserMap](
	[ProjectUserMapID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NULL,
	[UserInfoID] [int] NULL,
	[Selfcomments] [nvarchar](max) NULL,
	[ManagementComments] [nvarchar](max) NULL,
	[AssessmentYearID] [int] NULL,
	[ProjectLeadID] [int] NULL,
	[AssessmentModeID] [int] NULL,
 CONSTRAINT [PK_AMS_ProjectUserMap] PRIMARY KEY CLUSTERED 
(
	[ProjectUserMapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ProjectWorkType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ProjectWorkType](
	[ProjectWorkTypeID] [int] IDENTITY(-1,-1) NOT NULL,
	[WorkTypeDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_AMS_ProjectWorkType] PRIMARY KEY CLUSTERED 
(
	[ProjectWorkTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Requirement]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Requirement](
	[RequirementID] [int] IDENTITY(1,1) NOT NULL,
	[ComponentID] [int] NULL,
	[RequirementName] [nvarchar](500) NULL,
	[RDescription] [nvarchar](1000) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdatedBy] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_AMS_Requirement] PRIMARY KEY CLUSTERED 
(
	[RequirementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_RequirementDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_RequirementDescription](
	[RequirementDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[RequirementID] [int] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_RequirementDescription] PRIMARY KEY CLUSTERED 
(
	[RequirementDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_RequirementFile]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_RequirementFile](
	[RequirementFileID] [int] IDENTITY(1,1) NOT NULL,
	[FileBinary] [varbinary](max) NULL,
	[RequirementID] [int] NULL,
	[RequirementLogID] [int] NULL,
 CONSTRAINT [PK_AMS_RequirementFile] PRIMARY KEY CLUSTERED 
(
	[RequirementFileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_RequirementLog]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_RequirementLog](
	[RequirementLogID] [int] IDENTITY(1,1) NOT NULL,
	[RequirementID] [int] NULL,
	[LogCreatedBy] [int] NULL,
	[LogCreatedDate] [datetime] NULL,
	[LogType] [int] NULL,
 CONSTRAINT [PK_AMS_RequirementLog] PRIMARY KEY CLUSTERED 
(
	[RequirementLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_RequirementLogDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_RequirementLogDescription](
	[RequirementLogDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[RequirementLogID] [int] NULL,
	[RequirementDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_RequirementLogDescription] PRIMARY KEY CLUSTERED 
(
	[RequirementLogDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Role]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_AMS_Role_1] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Scenario]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Scenario](
	[ScenarioID] [int] IDENTITY(1,1) NOT NULL,
	[RequirementID] [int] NULL,
	[ShortDescription] [nvarchar](500) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdatedBy] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_AMS_Scenario] PRIMARY KEY CLUSTERED 
(
	[ScenarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ScenarioDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ScenarioDescription](
	[ScenarioDesriptionID] [int] IDENTITY(1,1) NOT NULL,
	[ScenarioID] [int] NULL,
	[ScenarioDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_ScenarioDescription] PRIMARY KEY CLUSTERED 
(
	[ScenarioDesriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ScenarioLog]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ScenarioLog](
	[ScenarioLogID] [int] IDENTITY(1,1) NOT NULL,
	[ScenarioID] [int] NULL,
	[LogCreatedBy] [int] NULL,
	[LogCreatedDate] [datetime] NULL,
	[LogType] [int] NULL,
 CONSTRAINT [PK_AMS_ScenarioLog] PRIMARY KEY CLUSTERED 
(
	[ScenarioLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_ScenarioLogDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_ScenarioLogDescription](
	[ScenarioLogDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[ScenarioLogID] [int] NULL,
	[ScenarioDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_ScenarioLogDescription] PRIMARY KEY CLUSTERED 
(
	[ScenarioLogDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_SubTask]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_SubTask](
	[SubTaskID] [int] IDENTITY(-1,-1) NOT NULL,
	[SubTaskDescription] [nvarchar](100) NULL,
	[TaskID] [int] NULL,
 CONSTRAINT [PK_AMS_SubTask] PRIMARY KEY CLUSTERED 
(
	[SubTaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Task]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Task](
	[TaskID] [int] IDENTITY(1,1) NOT NULL,
	[TaskDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_AMS_Task] PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TechnicalPerformance]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TechnicalPerformance](
	[TechnicalPerformanceID] [int] IDENTITY(1,1) NOT NULL,
	[RatingName] [nvarchar](500) NULL,
	[RatingDescription] [nvarchar](3000) NULL,
	[ISCRM] [bit] NULL,
	[ISHR] [bit] NULL,
	[IsEmployee] [bit] NULL,
 CONSTRAINT [PK_TechnicalPerformanceID] PRIMARY KEY CLUSTERED 
(
	[TechnicalPerformanceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TechnicalRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TechnicalRatings](
	[TechnicalRatingsID] [int] IDENTITY(1,1) NOT NULL,
	[UserInfoID] [int] NULL,
	[Rating] [decimal](18, 2) NULL,
	[TechnicalPerformanceID] [int] NULL,
	[AssessmentYearID] [int] NULL,
	[RatingUserID] [int] NULL,
	[AssessmentModeID] [int] NULL,
 CONSTRAINT [PK_AMS_TechnicalRatings] PRIMARY KEY CLUSTERED 
(
	[TechnicalRatingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_Testcase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_Testcase](
	[TestcaseID] [int] IDENTITY(1,1) NOT NULL,
	[ScenarioID] [int] NULL,
	[TestcaseName] [nvarchar](1000) NULL,
	[Complexity] [int] NULL,
	[Severity] [int] NULL,
	[TestcaseType] [int] NULL,
	[RegressionRequired] [bit] NULL,
	[ProjectPhaseID] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdatedBy] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_AMS_Testcase] PRIMARY KEY CLUSTERED 
(
	[TestcaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TestcaseDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TestcaseDescription](
	[TestcaseDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[TestcaseID] [int] NULL,
	[TestSteps] [nvarchar](max) NULL,
	[ExpectedResult] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_TestcaseDescription] PRIMARY KEY CLUSTERED 
(
	[TestcaseDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TestcaseLog]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TestcaseLog](
	[TestcaseLogID] [int] IDENTITY(1,1) NOT NULL,
	[TestcaseID] [int] NULL,
	[LogCreatedBy] [int] NULL,
	[LogCreatedDate] [datetime] NULL,
	[LogType] [int] NULL,
 CONSTRAINT [PK_AMS_TestcaseLog] PRIMARY KEY CLUSTERED 
(
	[TestcaseLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TestcaseLogDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TestcaseLogDescription](
	[TestcaseLogDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[TestcaseLogID] [int] NULL,
	[TestSteps] [nvarchar](max) NULL,
	[ExpectedResult] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_TestcaseLogDescription] PRIMARY KEY CLUSTERED 
(
	[TestcaseLogDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TestExecution]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TestExecution](
	[TestExecutionID] [int] IDENTITY(1,1) NOT NULL,
	[DevBuildID] [int] NULL,
	[TestcaseID] [int] NULL,
	[TestStatus] [bit] NULL,
	[Testdata] [nvarchar](500) NULL,
	[Comments] [nvarchar](2000) NULL,
	[Testdate] [datetime] NULL,
	[Testedby] [int] NULL,
 CONSTRAINT [PK_AMS_TestExecution] PRIMARY KEY CLUSTERED 
(
	[TestExecutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TestExecutionLog]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TestExecutionLog](
	[TestExecutonLogID] [int] IDENTITY(1,1) NOT NULL,
	[TestExecutionID] [int] NULL,
	[TestStatus] [bit] NULL,
	[Testdata] [nvarchar](500) NULL,
	[Comments] [nvarchar](2000) NULL,
	[Testdate] [datetime] NULL,
	[Testedby] [int] NULL,
 CONSTRAINT [PK_AMS_TestExecutionLog] PRIMARY KEY CLUSTERED 
(
	[TestExecutonLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_TimeSheet]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_TimeSheet](
	[TimesheetID] [int] IDENTITY(1,1) NOT NULL,
	[LogDate] [date] NULL,
	[DayLogin] [datetime] NULL,
	[DayLogout] [datetime] NULL,
	[LunchLogin] [datetime] NULL,
	[LunchLogout] [datetime] NULL,
	[DayMins] [int] NULL,
	[LunchMins] [int] NULL,
	[EmployeeID] [int] NULL,
	[MachineName] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[IPAddress] [nvarchar](50) NULL,
	[BreakMins] [int] NULL,
	[DayID] [int] NULL,
 CONSTRAINT [PK_AMS_TimeSheet] PRIMARY KEY CLUSTERED 
(
	[TimesheetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_UserInfo]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_UserInfo](
	[UserInfoID] [int] IDENTITY(1,1) NOT NULL,
	[OrgID] [int] NULL,
	[BranchID] [int] NULL,
	[UserName] [nvarchar](50) NULL,
	[Passwordstring] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[CNumber] [nvarchar](50) NULL,
	[EMail] [nvarchar](50) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[RoleID] [int] NULL,
	[DesignationID] [int] NULL,
	[ReportingLeadID] [int] NULL,
	[IsOTP] [bit] NULL,
	[Gender] [bit] NULL,
	[JoingDate] [date] NULL,
	[DOB] [date] NULL,
	[DepatmentID] [int] NULL,
	[EmployeeStatus] [bit] NULL,
	[EnableAssessmnet] [bit] NULL,
	[HR] [int] NULL,
 CONSTRAINT [PK_AMS_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserInfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UC_AMS_UName] UNIQUE NONCLUSTERED 
(
	[BranchID] ASC,
	[FullName] ASC,
	[CNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_WorkPlaceRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_WorkPlaceRatings](
	[WorkPlaceRatingsID] [int] IDENTITY(1,1) NOT NULL,
	[RatingsDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_AMS_WorkPlaceRatings] PRIMARY KEY CLUSTERED 
(
	[WorkPlaceRatingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_WorkPlaceRatingsComments]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_WorkPlaceRatingsComments](
	[WorkPlaceRatingsCommentsID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[AssessmentYearID] [int] NULL,
	[AssessmentModeID] [int] NULL,
	[Improvements] [nvarchar](max) NULL,
	[Appreciations] [nvarchar](max) NULL,
	[AditionalContributions] [int] NULL,
	[AdtionalRole] [nvarchar](500) NULL,
	[AchivedGoals] [nvarchar](max) NULL,
	[SelfGoalForYear] [nvarchar](1000) NULL,
	[SelfGoalforHalfYear] [nvarchar](1000) NULL,
	[SelfGoalForHalfYearDetails] [nvarchar](max) NULL,
	[MGoalsAssessment] [nvarchar](max) NULL,
	[MGoalForYear] [nvarchar](1000) NULL,
	[MGoalforHalfYear] [nvarchar](1000) NULL,
	[MGoalForHalfYearDetails] [nvarchar](max) NULL,
 CONSTRAINT [PK_AMS_WorkPlaceRatingsComments] PRIMARY KEY CLUSTERED 
(
	[WorkPlaceRatingsCommentsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_WorkPlaceRatingsMap]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_WorkPlaceRatingsMap](
	[WorkPlaceRatingsMapID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[WorkPlaceRatingsID] [int] NULL,
	[Rating] [int] NULL,
	[AssessmentYearID] [int] NULL,
	[AssessmentModeID] [int] NULL,
 CONSTRAINT [PK_AMS_WorkPlaceRatingsMap] PRIMARY KEY CLUSTERED 
(
	[WorkPlaceRatingsMapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AMS_WorkType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AMS_WorkType](
	[WorkTypeID] [int] IDENTITY(1,1) NOT NULL,
	[WorkTypedescription] [nvarchar](100) NULL,
	[TaskID] [int] NULL,
	[SubTaskID] [int] NULL,
 CONSTRAINT [PK_AMS_WorkType] PRIMARY KEY CLUSTERED 
(
	[WorkTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[Name] [nvarchar](1000) NULL,
	[Value] [nvarchar](1000) NULL,
	[Comment] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AMS_AYearandUserforMS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_AYearandUserforMS]        
As        
Begin        
        
select FYearID AS AssessmentYearID,
FYearName AS AssessmentYearName 
from AMS_FYear    
WHERE ISNULL(EnableAssessment,0) = 1
        
End 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Check_DBVersion]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Check_DBVersion]
as
begin

select LookupValue from AMS_Lookup where LookupID = 3

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_Component]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Del_Component]  
@ComponentID int,  
@UserID int ,
@ProjectPhaseID int
AS  
BEGIN  
  
update AMS_Component set Status = 0   
where ComponentID = @ComponentID  
  
INSERT INTO AMS_ComponentLog(ComponentID,LogCreatedBy,LogCreatedDate,LogType)  
VALUES(@ComponentID,@UserID,GETDATE(),18)  
  
SELECT  @ComponentID  
exec AMS_Get_Component @ProjectPhaseID  
  
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_EmployeeTask]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Del_EmployeeTask]
@EmployeeTaskID INT
as
begin
DELETE FROM AMS_EmployeeTask WHERE EmployeeTaskID = @EmployeeTaskID
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_Holiday]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Del_Holiday]
@HolidayID int
as
begin

delete from AMS_HoliDay where HolidayID = @HolidayID

select @HolidayID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_Project]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Del_Project]  
@ProjectID int  
as  
begin  
  
delete from AMS_Projects where ProjectID = @ProjectID  
SELECT @ProjectID
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_ProjectEmployeeMap]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Del_ProjectEmployeeMap]
@ProjectEmployeeMapID int = 0
as
begin
delete from AMS_ProjectEmployeeMap 
where ProjectEmployeeMapID = @ProjectEmployeeMapID
select @ProjectEmployeeMapID
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_ProjectPhase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Del_ProjectPhase]
@ProjectPhaseID int
as
begin

delete from AMS_ProjectPhase where ProjectPhaseID = @ProjectPhaseID
select @ProjectPhaseID
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Del_UserInfo]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AMS_Del_UserInfo]
@UserInfoID int = 0
as
begin

delete from AMS_UserInfo where UserInfoID = @UserInfoID

select @UserInfoID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_AssessmentMode]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_AssessmentMode]
as
begin

select AssessmentModeID,AssessmentModeName from AMS_AssessmentMode

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_GeT_ChangeLog]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AMS_GeT_ChangeLog]  
@ID int,  
@Type int  
as  
begin  
if(@Type = 1)
begin  
select U.FullName,CL.LogCreatedDate,L.LookupValue from AMS_ComponentLog CL   
left join AMS_UserInfo U on CL.LogCreatedBy = U.UserInfoID  
left join AMS_Lookup L on CL.LogType = L.LookupID  
where ComponentID = @ID  
end  
else if(@Type = 2)
begin  
select U.FullName,CL.LogCreatedDate,L.LookupValue from AMS_RequirementLog CL   
left join AMS_UserInfo U on CL.LogCreatedBy = U.UserInfoID  
left join AMS_Lookup L on CL.LogType = L.LookupID  
where RequirementID = @ID  
end  
else if(@Type = 3)
begin  
select U.FullName,CL.LogCreatedDate,L.LookupValue from AMS_ScenarioLog CL   
left join AMS_UserInfo U on CL.LogCreatedBy = U.UserInfoID  
left join AMS_Lookup L on CL.LogType = L.LookupID  
where ScenarioID = @ID  
end  
else if(@Type = 4)
begin  
select U.FullName,CL.LogCreatedDate,L.LookupValue from AMS_TestcaseLog CL   
left join AMS_UserInfo U on CL.LogCreatedBy = U.UserInfoID  
left join AMS_Lookup L on CL.LogType = L.LookupID  
where TestcaseID = @ID  
end
else if(@Type = 5)
begin  
select U.FullName,CL.LogCreatedDate,L.LookupValue from AMS_DevBuildLog CL
left join AMS_UserInfo U on CL.LogCreatedBy = U.UserInfoID  
left join AMS_Lookup L on CL.LogType = L.LookupID  
where DevBuildID = @ID  
end
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOff]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_CompOff]                  
@EmployeeID int                  
as                  
begin                  
                  
                  
select CompensatoryLeaveID,                
CONVERT(DATE,LeaveDate) AS  LeaveDate,                
LeaveReason,                
LS.LeaveStatusName ,                
LD.LookupValue AS LeaveDuration,              
C.LeaveDurationID,              
C.leavedays,        
C.LeaveStatus,      
C.AvailedDays,  
C.StatusChangeComments,
ISNULL(C.Availeddate,'') as Availeddate
from AMS_CompensatoryLeave C                   
LEFT JOIN AMS_LeaveStatus LS on C.LeaveStatus = LS.LeaveStatusID                  
inner JOIN AMS_Lookup LD on C.LeaveDurationID = LD.LookupID                
where EmployeeID = @EmployeeID                  
order by C.LeaveDate DESC                  
                  
select CLA.CompensatoryLeaveID, CLA.LeadID,U.FullName,                  
case when CLA.ApprovalStatus = 9 then 'Approved'            
when CLA.ApprovalStatus = 10 then 'Rejected'             
else 'Approval Pending' end AS Approved,                  
CLA.ApporvedDate                  
from AMS_CompensatoryLeaveApproval CLA inner join                  
AMS_CompensatoryLeave  CL on CLA.CompensatoryLeaveID = CL.CompensatoryLeaveID                  
left join AMS_UserInfo U on CLA.LeadID = U.UserInfoID                  
where CL.EmployeeID = @EmployeeID                  
                  
                  
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOffDetailsByID]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_CompOffDetailsByID]
@CompensatoryLeaveID int
as
begin

DECLARE @LeadIDs nvarchar(100)

set @LeadIDs = (SELECT STUFF
(
    (
        SELECT ',' + cast(s.LeadID as nvarchar)
        FROM AMS_CompensatoryLeaveApproval s where CompensatoryLeaveID = @CompensatoryLeaveID
        ORDER BY s.LeadID FOR XML PATH('')
    ),
     1, 1, ''
) AS Employees)

select
CompensatoryLeaveID,LeaveDate,LeaveStatus,LeaveReason,
LeaveDurationID,@LeadIDs AS Leads
from AMS_CompensatoryLeave
where CompensatoryLeaveID = @CompensatoryLeaveID

End
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOffForApporval]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_CompOffForApporval]            
@LeadID int = 0            
as            
begin            
      
select C.CompensatoryLeaveID,              
CONVERT(DATE,LeaveDate) AS LeaveDate,              
LeaveReason,              
LS.LeaveStatusName ,              
LD.LookupValue AS LeaveDuration,            
C.LeaveDurationID,            
C.leavedays,      
U.FullName,
U.EMail
from AMS_CompensatoryLeave C                 
inner join AMS_UserInfo U on C.EmployeeID = U.UserInfoID      
LEFT JOIN AMS_LeaveStatus LS on C.LeaveStatus = LS.LeaveStatusID                
inner JOIN AMS_Lookup LD on C.LeaveDurationID = LD.LookupID              
inner join AMS_CompensatoryLeaveApproval CLA on C.CompensatoryLeaveID = CLA.CompensatoryLeaveID      
where LeadID = @LeadID and ISNULL(CLA.ApprovalStatus,0)= 0 AND C.LeaveStatus = 5    
order by C.LeaveDate DESC                
      
select CLA.CompensatoryLeaveApprovalID,      
CLA.CompensatoryLeaveID, CLA.LeadID,U.FullName,                
case when CLA.ApprovalStatus = 9 then 'Approved'          
when CLA.ApprovalStatus = 10 then 'Rejected'           
else 'Approval Pending' end AS Approved,                
CLA.ApporvedDate                
from AMS_CompensatoryLeaveApproval CLA inner join                
(select CL.CompensatoryLeaveID from AMS_CompensatoryLeave CL inner join AMS_CompensatoryLeaveApproval CLA       
on CL.CompensatoryLeaveID = CLA.CompensatoryLeaveID where LeadID = @LeadID and ISNULL(CLA.ApprovalStatus,0)= 0    
AND Cl.LeaveStatus = 5)      
CL on CLA.CompensatoryLeaveID = CL.CompensatoryLeaveID      
left join AMS_UserInfo U on CLA.LeadID = U.UserInfoID        
            
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_CompOffForLead]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_CompOffForLead]  
as                    
begin                    
                   
select CompensatoryLeaveID,                  
CONVERT(DATE,LeaveDate) AS  LeaveDate,                  
LeaveReason,                  
LS.LeaveStatusName ,                  
LD.LookupValue AS LeaveDuration,                
C.LeaveDurationID,                
C.leavedays,          
C.LeaveStatus,        
C.AvailedDays,    
C.StatusChangeComments,  
U.FullName,
ISNULL(C.Availeddate,'') AS  Availeddate
from AMS_CompensatoryLeave C                     
LEFT JOIN AMS_LeaveStatus LS on C.LeaveStatus = LS.LeaveStatusID                    
inner JOIN AMS_Lookup LD on C.LeaveDurationID = LD.LookupID                  
INNER JOIN AMS_UserInfo U ON C.EmployeeID = U.UserInfoID  
where ISNULL(U.EmployeeStatus,1) = 1

order by C.LeaveDate DESC                    
                
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Component]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Component]      
@ProjectPhaseID int      
as      
begin      
      
select  CP.ComponentID,CP.ComponentName,C.FullName As CreatedBy,CP.CreatedDate,    
U.FullName AS LastUpdatedBy ,CP.LastUpdatedDate    
from AMS_Component CP    
left join AMS_UserInfo C on CP.CreatedBy = C.UserInfoID    
left join AMS_UserInfo U on CP.LastUpdatedBy = U.UserInfoID    
where ProjectPhaseID = @ProjectPhaseID  and ISNULL(Status,1) = 1    
      
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ComponentDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ComponentDescription]
@ComponentID  INT = 0
AS

BEGIN

SELECT ComponentDescription FROM AMS_ComponentDescription 
WHERE ComponentID = @ComponentID 

END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ComponentForDropDown]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ComponentForDropDown]
@ProjectPhaseID int        
as        
begin        
        
select  CP.ComponentID,CP.ComponentName
from AMS_Component CP      
where ProjectPhaseID = @ProjectPhaseID  and ISNULL(Status,1) = 1      
        
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Dashboard]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_Dashboard]                        
@SelectedDate date                        
as                                        
begin                                        
                      
select E.UserInfoID,                      
E.UserName,E.FullName,                      
case WHEN T.TimesheetID is null AND h.EmployeeID IS NOT NULL THEN 'On Leave'          
when T.TimesheetID is null then 'Not Logged in'                      
when T.LunchLogin is not null and T.LunchLogout is null then 'On Lunch Break'                      
when T.DayBreakID is not null then 'On Break'                      
when T.DayLogout is not null then 'Logged out'                      
else 'Logged in' end as EmployeeStatus,                                        
                                        
case when T.TimesheetID is null AND h.EmployeeID IS NOT NULL then 0          
when T.TimesheetID is null then 1                      
when T.LunchLogin is not null and T.LunchLogout is null then 2                      
when T.DayBreakID is not null then 3                      
when T.DayLogout is not null then 5                      
else 4 end as StateCode,                      
T.DayLogin,                      
T.DayLogout,                      
T.LunchLogin,                      
T.LunchLogout,                      
T.BreakLogin,                      
T.BreakLogout,                      
dbo.AMS_GetHours(T.DayMins) as TodayHours,    
dbo.AMS_GetHours(T.LunchMins) as LunchHours,    
dbo.AMS_GetHours(T.BreakMins) as BreakHours    
FROM AMS_UserInfo E                
left join (SELECT T.TimesheetID,                
T.DayLogin,T.DayLogout,T.LunchLogin,T.LunchLogout,                      
D.DayBreakID,D.BreakLogin,D.BreakLogout,T.EmployeeID,                      
T.LunchMins,T.DayMins,T.BreakMins                      
FROM AMS_TimeSheet T                      
LEFT JOIN AMS_DayBreak D on T.TimesheetID = D.TimesheetID                       
and D.BreakLogin is not null and D.BreakLogout is null                      
WHERE CONVERT(DATE,LogDate) = CONVERT(date,@SelectedDate))T                      
on E.UserInfoID = T.EmployeeID                      
LEFT JOIN (SELECT  distinct EmployeeID FROM AMS_EmployeeLeave           
WHERE @SelectedDate >= LeaveFromDate AND @SelectedDate <= LeaveToDate    
AND (LeaveStatusID = 1 OR LeaveStatusID = 5 OR LeaveStatusID = 4)) H  
ON E.UserInfoID = H.EmployeeID          
where ISNULL(E.EmployeeStatus,1) = 1

end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DayBreaks]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_DayBreaks]            
@EmployeeID INT = 0,  
@TimeSheetID int = 0  
as            
begin            
            
if(@TimeSheetID <= 0)  
begin  
select @TimeSheetID  = TimesheetID from AMS_TimeSheet                   
where EmployeeID = @EmployeeID                   
and CONVERT(date,LogDate)  =CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))    
end  
            
SELECT DayBreakID,         
BreakLogin,        
BreakLogout,         
dbo.AMS_GetHours(BreakMins) AS BreakMins from AMS_DayBreak             
where TimesheetID = @TimeSheetID            
            
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DayBreaksByID]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_DayBreaksByID]
@TimesheetID INT
AS
BEGIN

SELECT DayBreakID,           
BreakLogin,          
BreakLogout,           
dbo.AMS_GetHours(BreakMins) AS BreakMins from AMS_DayBreak               
where TimesheetID = @TimeSheetID

END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DeatailsByType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_DeatailsByType]                          
@LeaveTypeID int,                          
@FYearID int,                        
@EmployeeID int                        
AS                          
BEGIN                          
                          
select TotalLeaves,ProRataLeaves,LeavesAvailed,LeaveBalance
from AMS_GetLeaveDetailsByType (@LeaveTypeID ,@FYearID,@EmployeeID)  
                          
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Designation]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Designation]
as
begin
select DesignationID,DesignationName from AMS_Designation
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DevBuild]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_DevBuild]    
@ProjectPhaseID int      
as      
begin      
      
select DevBuildID,ProjectID,ProjectPhaseID,BuildVersion,      
BuildPath,ImpactAnalysis,ImpactModules,BuildChanges,    
C.FullName As CreatedBy,      
B.CreatedDate,      
U.FullName As LastUpdatedBy,      
B.LastUpdatedDate,      
Case when B.BuildStatus = 1 then 'Created'      
when B.BuildStatus = 2 then 'QA InProgress'      
when B.BuildStatus = 3 then 'QA Completed' end as BuildStatus      
from AMS_DevBuild B      
left join AMS_UserInfo C on B.CreatedBy = C.UserInfoID      
left join AMS_UserInfo U on B.LastupdatedBy = U.UserInfoID      
where ProjectPhaseID = @ProjectPhaseID      
      
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_DevBuildForQA]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_DevBuildForQA]      
@ProjectPhaseID int      
as      
begin      
      
select DevBuildID,ProjectID,ProjectPhaseID,BuildVersion,          
BuildPath,ImpactAnalysis,ImpactModules,BuildChanges,        
C.FullName As CreatedBy,          
B.CreatedDate,          
U.FullName As LastUpdatedBy,          
B.LastUpdatedDate,          
Case when B.BuildStatus = 1 then 'Created'          
when B.BuildStatus = 2 then 'QA InProgress'  
when B.BuildStatus = 3 then 'QA Completed' end as BuildStatus          
from AMS_DevBuild B          
left join AMS_UserInfo C on B.CreatedBy = C.UserInfoID          
left join AMS_UserInfo U on B.LastupdatedBy = U.UserInfoID          
where ProjectPhaseID = @ProjectPhaseID
      
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeDetialsByID]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_EmployeeDetialsByID]  
@EmployeeID INT  
as  
begin  
  
SELECT                              
U.UserInfoID,                              
U.UserName,                              
U.FullName,                              
U.Passwordstring,            
U.DesignationID,            
U.ReportingLeadID,            
D.DesignationName,            
RL.FullName AS ReportingLead,    
U.RoleID    
FROM AMS_UserInfo U         
INNER JOIN AMS_Role R on U.RoleID = r.RoleID        
left JOIN AMS_Designation D on U.DesignationID = D.DesignationID            
left JOIN AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID            
WHERE U.UserInfoID = @EmployeeID        
  
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_EmployeeForDS]
@UserInfoID INT
As
begin

SELECT UserInfoID,FullName
FROM AMS_UserInfo WHERE UserInfoID <>@UserInfoID
and ISNULL(EmployeeStatus,1) = 1

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeforGR]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_EmployeeforGR]  
@UserInfoID INT,  
@AssessmentYearID INT  
as  
begin  
  
SELECT UserInfoID,FullName FROM AMS_UserInfo
where RoleID in (3,4,6,7) and UserInfoID <> @UserInfoID
and ISNULL(EmployeeStatus,1) = 1

  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeforLRating]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AMS_Get_EmployeeforLRating]
@UserInfoID int,        
@AssessmentyearID INT        
AS        
BEGIN        
        
select         
U.UserInfoID,U.FullName  from
AMS_UserInfo U where RoleID in (3,6,7) 
and UserInfoID <> @UserInfoID
and ISNULL(EmployeeStatus,1) = 1
        
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeforProjectRating]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AMS_Get_EmployeeforProjectRating]    
@UserInfoID int,        
@AssessmentyearID INT,
@AssessmentModeID INT
AS        
BEGIN        
        
create table #EDetails(UserInfoID INT)        
        
INSERT INTO #EDetails(UserInfoID)        
select UserInfoID from AMS_UserInfo where ReportingLeadID = @UserInfoID        
and ISNULL(EmployeeStatus,1) = 1
        
INSERT INTO #EDetails(UserInfoID)        
select distinct UserInfoID from AMS_ProjectUserMap PU    
where  ProjectLeadID = @UserInfoID and AssessmentYearID = @AssessmentyearID    
and AssessmentModeID = @AssessmentModeID
and not exists (select 1 from #EDetails E where E.UserInfoID = PU.UserInfoID)  
        
select         
E.UserInfoID,U.FullName        
from #EDetails E inner join AMS_UserInfo U         
on E.UserInfoID = U.UserInfoID  

END  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeList]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_EmployeeList]    
@EmployeeID int = 0  
AS    
BEGIN    
    
SELECT UserInfoID,UserName,FullName,EMail FROM AMS_UserInfo   
    
END    
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeListForLeaveApproval]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_EmployeeListForLeaveApproval]        
@EmployeeID int = 0      
AS        
BEGIN        
        
SELECT UserInfoID,UserName,FullName,EMail FROM AMS_UserInfo       
WHERE (RoleID = 1 OR RoleID = 3 OR RoleID = 7) AND UserInfoID <> @EmployeeID      
AND ISNULL(EmployeeStatus,1) = 1      
        
END   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeTaks]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_EmployeeTaks]          
@EmployeeID int = 0,    
@LeadID int = 0,    
@RoleID int = 0    
as              
begin              
  
DECLARE @ReportingLEadID int  
select @ReportingLEadID = ReportingLeadID from AMS_UserInfo where UserInfoID = @EmployeeID  
    
if(@RoleID = 1 OR @RoleID = 7 OR @RoleID = 6 OR @LeadID = @ReportingLEadID)  
BEGIN    
 select ET.EmployeeTaskID,ET.TaskHours AS TaskMins,ET.TaskDescription AS EmployeeTaskDescription,            
 TS.LogDate,T.TaskDescription,ST.SubTaskDescription,WT.WorkTypedescription,              
 dbo.AMS_GetHours(TaskHours) AS TaskHours,              
 ET.TaskID,ET.SubTaskID,ET.WorkTypeID              
 from AMS_EmployeeTask ET               
 inner join AMS_TimeSheet TS on ET.TimesheetID = TS.TimesheetID              
 inner join AMS_Task T on ET.TaskID = T.TaskID              
 inner join dbo.SubTask() ST on ET.SubTaskID = ST.SubTaskID              
 inner join (select distinct WorkTypeID,WorkTypedescription from dbo.WorkType()) WT on ET.WorkTypeID = WT.WorkTypeID              
 where ET.EmployeeID = @EmployeeID            
 order BY TS.LogDate desc      
END    
ELSE   
BEGIN    
 select ET.EmployeeTaskID,ET.TaskHours AS TaskMins,ET.TaskDescription AS EmployeeTaskDescription,            
 TS.LogDate,T.TaskDescription,ST.SubTaskDescription,WT.WorkTypedescription,              
 dbo.AMS_GetHours(TaskHours) AS TaskHours,              
 ET.TaskID,ET.SubTaskID,ET.WorkTypeID              
 from AMS_EmployeeTask ET               
 inner join AMS_TimeSheet TS on ET.TimesheetID = TS.TimesheetID              
 inner join AMS_Task T on ET.TaskID = T.TaskID              
 inner join dbo.SubTask() ST on ET.SubTaskID = ST.SubTaskID              
 inner join (select distinct WorkTypeID,WorkTypedescription from dbo.WorkType()) WT on ET.WorkTypeID = WT.WorkTypeID              
 INNER JOIN AMS_Projects P ON ST.SubTaskID = P.ProjectID    
 where ET.EmployeeID = @EmployeeID AND P.ProjectLeadID = @LeadID    
 order BY TS.LogDate desc      
END    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeTaskByID]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_EmployeeTaskByID]      
@TimesheetID int = 0          
as          
begin          
          
select ET.TaskID,ET.SubTaskID,ET.WorkTypeID,ET.TaskHours AS Hours,ET.TaskDescription AS EmployeeTaskDescription,        
T.TaskDescription,ST.SubTaskDescription,WT.WorkTypedescription,          
dbo.AMS_GetHours(TaskHours) AS stHours
from AMS_EmployeeTask ET           
inner join AMS_Task T on ET.TaskID = T.TaskID          
inner join dbo.SubTask() ST on ET.SubTaskID = ST.SubTaskID          
inner join (select distinct WorkTypeID,WorkTypedescription from dbo.WorkType()) WT on ET.WorkTypeID = WT.WorkTypeID          
where ET.TimesheetID = @TimesheetID		


end    
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_EmployeeTaskForLead]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_EmployeeTaskForLead]    
@EmployeeID INT
as      
begin      
      
select ET.EmployeeTaskID,ET.EmployeeID,ET.TaskID,        
ET.SubTaskID,ET.WorkTypeID,ET.TaskHours,ET.TaskDescription As EmployeeTaskDescription,        
T.TaskDescription,st.SubTaskDescription,wt.WorkTypedescription,      
(REPLICATE('0',2- LEN(Cast(TaskHours / 60 as Varchar))) + Cast(TaskHours / 60 as Varchar)) + ':' +      
(REPLICATE('0',2-LEN(Cast(TaskHours % 60 as Varchar))) + Cast(TaskHours % 60 as Varchar)) as THours      
from AMS_EmployeeTask ET inner join AMS_Task T ON ET.TaskID = T.TaskID        
inner join AMS_SubTask ST on et.SubTaskID = ST.SubTaskID        
inner join AMS_WorkType wt on et.WorkTypeID = wt.WorkTypeID        
where EmployeeID = @EmployeeID  
order by EmployeeTaskID desc  
      
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_FinalRating]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_FinalRating]    
@AssessmentYearID INT,    
@AssessmentModeID INT,    
@EmployeeID INT    
AS    
Begin    
    
DECLARE @TechnicalSkillsName nvarchar(500),@TechnicalSkillsRating decimal(18,2),    
@FocusName nvarchar(500),@FocusRating decimal(18,2),    
@OverallProjectName nvarchar(500),@OverAllProjectRating decimal(18,2),    
@InnovationName nvarchar(500),@InnovationRating decimal(18,2),    
@PreparationName nvarchar(500),@PreparationRating decimal(18,2),    
@KnowledgeName nvarchar(500),@KnowledgeRating decimal(18,2),    
@PublicName nvarchar(500),@PublicRating decimal(18,2),    
@TeamskillsName nvarchar(500),@TeamskillsRating decimal(18,2),    
@CommunicationName nvarchar(500),@CommunicationRating decimal(18,2)  
  
DECLARE @DesignationID INT  
SELECT @DesignationID = DesignationID FROM AMS_UserInfo WHERE UserInfoID = @EmployeeID  
    
CREATE TABLE #TDetails(TechnicalPerformanceID int,RatingName nvarchar(500),MA decimal(18,2))    

insert into #TDetails    
SELECT            
GR.TechnicalPerformanceID,                  
GP.RatingName,                  
cast(M.MA  as decimal(18,2)) as MA      
from AMS_TechnicalRatings GR                   
inner join AMS_TechnicalPerformance GP on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID                  
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID            
inner join (SELECT TechnicalPerformanceID, AVG(Rating) AS MA            
FROM AMS_TechnicalRatings WHERE AssessmentYearID = @AssessmentYearID        
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID group by TechnicalPerformanceID)M             
ON GR.TechnicalPerformanceID = M.TechnicalPerformanceID            
where GR.AssessmentYearID = @AssessmentYearID        
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID        
and GR.RatingUserID = @EmployeeID        
    
SELECT @TechnicalSkillsName = RatingName,@TechnicalSkillsRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 1    
SELECT @FocusName = RatingName,@FocusRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 2    
    
SELECT     
@OverallProjectName = 'Overall Project-based rating [average]',    
@OverAllProjectRating = CAST(AVG(M.MA) AS decimal(18,2))    
FROM  AMS_ProjectUserMap PU     
inner join (select AVG(A.Rating) AS MA,A.ProjectUserMapID from               
(SELECT AVG(Rating) as Rating,CriteriaID,ProjectUserMapID FROM AMS_ProjectCriteriaMap PC              
WHERE EXISTS (SELECT 1 FROM AMS_ProjectUserMap PU               
where PC.ProjectUserMapID = PU.ProjectUserMapID               
and PU.AssessmentYearID  = @AssessmentYearID  
and PU.AssessmentModeID = @AssessmentModeID
and PU.UserInfoID = @EmployeeID) and PC.UserInfoID <> @EmployeeID              
GROUP BY CriteriaID,ProjectUserMapID) as A group by A.ProjectUserMapID) M on PU.ProjectUserMapID = M.ProjectUserMapID      
WHERE PU.UserInfoID = @EmployeeID         
and AssessmentYearID = @AssessmentYearID        
and AssessmentModeID = @AssessmentModeID
    
CREATE TABLE #gDetails(GeneralPerformanceID int,RatingName nvarchar(500),MA decimal(18,2))    
    
INSERT INTO #gDetails    
SELECT          
GR.GeneralPerformanceID,                
GP.RatingName,                
cast(M.MA  as decimal(18,2)) as MA        
from AMS_GenaralRatings GR                 
inner join AMS_GeneralPerformance GP on GR.GeneralPerformanceID = GP.GeneralPerformanceID                
inner join (SELECT GeneralPerformanceID, AVG(Rating) AS MA          
FROM AMS_GenaralRatings WHERE AssessmentYearID = @AssessmentYearID        
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID  group by GeneralPerformanceID)M           
ON GR.GeneralPerformanceID = M.GeneralPerformanceID          
where GR.AssessmentYearID = @AssessmentYearID         
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID         
and GR.RatingUserID = @EmployeeID        
    
SELECT @InnovationName = RatingName,@InnovationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 3    
SELECT @PreparationName = RatingName,@PreparationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 4    
SELECT @KnowledgeName = RatingName,@KnowledgeRating = MA FROM #gDetails WHERE GeneralPerformanceID = 5    
SELECT @PublicName = RatingName,@PublicRating = MA FROM #gDetails WHERE GeneralPerformanceID = 6    
SELECT @TeamskillsName = RatingName,@TeamskillsRating = MA FROM #gDetails WHERE GeneralPerformanceID = 7    
SELECT @CommunicationName = RatingName,@CommunicationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 8    
    
select    
@TechnicalSkillsName as TechnicalSkillsName ,@TechnicalSkillsRating  as TechnicalSkillsRating ,    
@FocusName as FocusName ,@FocusRating  as FocusRating ,    
@OverallProjectName as OverallProjectName ,@OverAllProjectRating  as OverAllProjectRating,    
@InnovationName  as InnovationName,@InnovationRating  as InnovationRating,    
@PreparationName as PreparationName ,@PreparationRating  as PreparationRating,    
@KnowledgeName  as KnowledgeName,@KnowledgeRating  as KnowledgeRating,    
@PublicName  as PublicName,@PublicRating  as PublicRating,    
@TeamskillsName As TeamskillsName,@TeamskillsRating as TeamskillsRating,    
@CommunicationName as CommunicationName,@CommunicationRating as CommunicationRating    
    
    
    
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_FinalRatingWithLR]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_FinalRatingWithLR]    
@AssessmentYearID INT,      
@AssessmentModeID INT,      
@EmployeeID INT      
AS      
Begin      
      
DECLARE @TechnicalSkillsName nvarchar(500),@TechnicalSkillsRating decimal(18,2),      
@FocusName nvarchar(500),@FocusRating decimal(18,2),      
@OverallProjectName nvarchar(500),@OverAllProjectRating decimal(18,2),      
@LeadSkillsName nvarchar(500),@LeadSkillsRating decimal(18,2),      
@InnovationName nvarchar(500),@InnovationRating decimal(18,2),      
@PreparationName nvarchar(500),@PreparationRating decimal(18,2),      
@KnowledgeName nvarchar(500),@KnowledgeRating decimal(18,2),      
@PublicName nvarchar(500),@PublicRating decimal(18,2),      
@TeamskillsName nvarchar(500),@TeamskillsRating decimal(18,2),      
@CommunicationName nvarchar(500),@CommunicationRating decimal(18,2)      
      
DECLARE @DesignationID INT  
SELECT @DesignationID = DesignationID FROM AMS_UserInfo WHERE UserInfoID = @EmployeeID  
      
CREATE TABLE #TDetails(TechnicalPerformanceID int,RatingName nvarchar(500),MA decimal(18,2))      
  
insert into #TDetails      
SELECT              
GR.TechnicalPerformanceID,                    
GP.RatingName,                    
cast(M.MA  as decimal(18,2)) as MA        
from AMS_TechnicalRatings GR                     
inner join AMS_TechnicalPerformance GP on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID                    
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID              
inner join (SELECT TechnicalPerformanceID, AVG(Rating) AS MA              
FROM AMS_TechnicalRatings WHERE AssessmentYearID = @AssessmentYearID  
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID group by TechnicalPerformanceID)M               
ON GR.TechnicalPerformanceID = M.TechnicalPerformanceID              
where GR.AssessmentYearID = @AssessmentYearID          
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID          
and GR.RatingUserID = @EmployeeID          
  
if(@DesignationID = 3)  
begin  
SELECT @TechnicalSkillsName = RatingName,@TechnicalSkillsRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 3  
SELECT @FocusName = RatingName,@FocusRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 4  
end  
else if(@DesignationID = 7)  
begin  
SELECT @TechnicalSkillsName = RatingName,@TechnicalSkillsRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 5  
SELECT @FocusName = RatingName,@FocusRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 2  
end  
else  
begin  
SELECT @TechnicalSkillsName = RatingName,@TechnicalSkillsRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 1  
SELECT @FocusName = RatingName,@FocusRating = MA FROM #TDetails WHERE TechnicalPerformanceID = 2  
end  
    
SELECT   @LeadSkillsRating =           
cast(AVG(M.MA)  as decimal(18,2))    
from AMS_LeadRatings GR                     
inner join AMS_LeadPerformance GP on GR.LeadPerformanceID = GP.LeadPerformanceID                    
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID              
inner join (SELECT LeadPerformanceID, AVG(Rating) AS MA              
FROM AMS_LeadRatings WHERE AssessmentYearID = @AssessmentYearID          
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID group by LeadPerformanceID)M               
ON GR.LeadPerformanceID = M.LeadPerformanceID              
where GR.AssessmentYearID = @AssessmentYearID          
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID          
and GR.RatingUserID = @EmployeeID          
      
SET @LeadSkillsName = 'Qualities of a Lead/ Fullfilment of responsibilities as a Lead [average]'    
    
SELECT       
@OverallProjectName = 'Overall Project-based rating [average]',      
@OverAllProjectRating = CAST(AVG(M.MA) AS decimal(18,2))      
FROM  AMS_ProjectUserMap PU       
inner join (select AVG(A.Rating) AS MA,A.ProjectUserMapID from                 
(SELECT AVG(Rating) as Rating,CriteriaID,ProjectUserMapID FROM AMS_ProjectCriteriaMap PC                
WHERE EXISTS (SELECT 1 FROM AMS_ProjectUserMap PU                 
where PC.ProjectUserMapID = PU.ProjectUserMapID            
and PU.AssessmentYearID  = @AssessmentYearID                
and PU.AssessmentModeID = @AssessmentModeID
and PU.UserInfoID = @EmployeeID) and PC.UserInfoID <> @EmployeeID                
GROUP BY CriteriaID,ProjectUserMapID) as A group by A.ProjectUserMapID) M on PU.ProjectUserMapID = M.ProjectUserMapID        
WHERE PU.UserInfoID = @EmployeeID           
and AssessmentYearID = @AssessmentYearID          
and AssessmentModeID = @AssessmentModeID
      
CREATE TABLE #gDetails(GeneralPerformanceID int,RatingName nvarchar(500),MA decimal(18,2))      
      
INSERT INTO #gDetails      
SELECT            
GR.GeneralPerformanceID,                  
GP.RatingName,                  
cast(M.MA  as decimal(18,2)) as MA          
from AMS_GenaralRatings GR                   
inner join AMS_GeneralPerformance GP on GR.GeneralPerformanceID = GP.GeneralPerformanceID                  
inner join (SELECT GeneralPerformanceID, AVG(Rating) AS MA            
FROM AMS_GenaralRatings WHERE AssessmentYearID = @AssessmentYearID          
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID  group by GeneralPerformanceID)M             
ON GR.GeneralPerformanceID = M.GeneralPerformanceID            
where GR.AssessmentYearID = @AssessmentYearID           
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID           
and GR.RatingUserID = @EmployeeID          
  
  
if(@DesignationID = 3)  
begin      
SELECT @InnovationName = RatingName,@InnovationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 3      
SELECT @PreparationName = RatingName,@PreparationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 9      
SELECT @KnowledgeName = RatingName,@KnowledgeRating = MA FROM #gDetails WHERE GeneralPerformanceID = 5      
SELECT @PublicName = RatingName,@PublicRating = MA FROM #gDetails WHERE GeneralPerformanceID = 6      
SELECT @TeamskillsName = RatingName,@TeamskillsRating = MA FROM #gDetails WHERE GeneralPerformanceID = 7      
SELECT @CommunicationName = RatingName,@CommunicationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 8      
end  
else  
begin  
SELECT @InnovationName = RatingName,@InnovationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 3      
SELECT @PreparationName = RatingName,@PreparationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 4      
SELECT @KnowledgeName = RatingName,@KnowledgeRating = MA FROM #gDetails WHERE GeneralPerformanceID = 5      
SELECT @PublicName = RatingName,@PublicRating = MA FROM #gDetails WHERE GeneralPerformanceID = 6      
SELECT @TeamskillsName = RatingName,@TeamskillsRating = MA FROM #gDetails WHERE GeneralPerformanceID = 7      
SELECT @CommunicationName = RatingName,@CommunicationRating = MA FROM #gDetails WHERE GeneralPerformanceID = 8      
end  
      
select      
@TechnicalSkillsName as TechnicalSkillsName , ISNULL(@TechnicalSkillsRating,0) as TechnicalSkillsRating ,      
@FocusName as FocusName ,ISNULL( @FocusRating ,0) as FocusRating ,      
@OverallProjectName as OverallProjectName ,ISNULL(@OverAllProjectRating,0)  as OverAllProjectRating,      
@InnovationName  as InnovationName,ISNULL(@InnovationRating ,0) as InnovationRating,      
@PreparationName as PreparationName ,ISNULL(@PreparationRating ,0) as PreparationRating,      
@KnowledgeName  as KnowledgeName,ISNULL(@KnowledgeRating ,0) as KnowledgeRating,      
@PublicName  as PublicName,ISNULL(@PublicRating,0) as PublicRating,      
@TeamskillsName As TeamskillsName,ISNULL(@TeamskillsRating,0) as TeamskillsRating,      
@CommunicationName as CommunicationName,ISNULL(@CommunicationRating,0) as CommunicationRating ,    
@LeadSkillsName AS   LeadSkillsName,ISNULL(@LeadSkillsRating,0) as LeadSkillsRating    
      
      
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_FYear]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_FYear]    
as                
begin                
    
if(MONTH(GETDATE()) = 1 OR MONTH(GETDATE()) = 2 OR MONTH(GETDATE()) = 3)    
BEGIN    
select FYearID,FYearName,FromDate,dbo.LDOMonth(ToDate) as ToDate,  
CASE WHEN FYearName = CAST(YEAR(GETDATE()) - 1 as varchar) + '-' + CAST(YEAR(GETDATE()) as varchar)      
THEN 1            
ELSE 0 END AS SELECTED,          
ISNULL(EnableAssessment,0) AS EnableAssessment          
from AMS_FYear            
END    
ELSE    
BEGIN    
select FYearID,FYearName,FromDate,dbo.LDOMonth(ToDate) AS ToDate,            
CASE WHEN FYearName = CAST(YEAR(GETDATE()) as varchar) + '-' + CAST(YEAR(GETDATE()) + 1 as varchar)      
THEN 1            
ELSE 0 END AS SELECTED,          
ISNULL(EnableAssessment,0) AS EnableAssessment          
from AMS_FYear            
END    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_GeneralRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_GeneralRatings]                            
@AssessmentYearID int,                            
@UserInfoID int ,                  
@ratingUserID int,  
@AssessmentModeID int  
AS                            
begin                            
              
if(@UserInfoID <> @ratingUserID)              
begin              
if not exists(select 1 from AMS_GenaralRatings               
where AssessmentYearID = @AssessmentYearID  
and AssessmentModeID = @AssessmentModeID  
and UserInfoID = @ratingUserID)  
begin  
return;  
end  
end  
      
declare @DesignationID int = 0      
select @DesignationID = DesignationID from AMS_UserInfo where UserInfoID = @ratingUserID      
              
if not exists(select 1 from AMS_GenaralRatings where                     
AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID AND  
UserInfoID = @ratingUserID and RatingUserID = @UserInfoID)                            
begin                            
      
if(@DesignationID = 3)      
begin                            
select GeneralPerformanceID,                            
RatingName,                            
RatingDescription,                          
'' as SA                          
from AMS_GeneralPerformance where ISCRM = 1      
end      
else      
begin      
select GeneralPerformanceID,                            
RatingName,                            
RatingDescription,                          
'' as SA                          
from AMS_GeneralPerformance where IsEmployee = 1          
end      
                          
end                            
else                          
begin                          
                          
select GR.GeneralPerformanceID,                          
GP.RatingName,                          
GP.RatingDescription,                          
GR.Rating as SA from AMS_GenaralRatings GR inner join AMS_GeneralPerformance GP                          
on GR.GeneralPerformanceID = GP.GeneralPerformanceID                          
where GR.AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID AND
GR.UserInfoID = @ratingUserID  and GR.RatingUserID = @UserInfoID                       
                          
end                          
                          
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_HoliDay]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_HoliDay]  
As  
begin  
  
select   
H.HolidayID,H.HolidayDate,H.HolidayName,H.CategoryID,L.LookupValue  
from AMS_HoliDay  H inner join  AMS_Lookup L  
on H.CategoryID = L.LookupID  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_HolidayType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[AMS_Get_HolidayType]
as
begin
select LookupID,LookupValue from 
AMS_Lookup where MapID = 1
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadDetails]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeadDetails]
@EmployeeLeaveID int
as
begin

SELECT LA.LeadID,U.UserName,U.EMail 
FROM AMS_LeaveApproval LA INNER JOIN AMS_UserInfo U
ON LA.LeadID = U.UserInfoID
WHERE EmoloyeeLeaveID = @EmployeeLeaveID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadDetailsForCompOffMail]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeadDetailsForCompOffMail]
@CompensatoryLeaveID int
AS
Begin

SELECT CLA.LeadID,U.UserName,U.EMail 
FROM AMS_CompensatoryLeaveApproval CLA INNER JOIN AMS_UserInfo U
ON CLA.LeadID = U.UserInfoID
WHERE CompensatoryLeaveID = @CompensatoryLeaveID

End
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeadRatings]          
@AssessmentYearID int,          
@UserInfoID int ,                
@ratingUserID int,
@AssessmentModeID INT
AS                          
begin                          
            
if(@UserInfoID <> @ratingUserID)            
begin            
if not exists(select 1 from AMS_LeadRatings          
where AssessmentYearID = @AssessmentYearID             
and AssessmentModeID = @AssessmentModeID  
and UserInfoID = @ratingUserID)            
begin            
return;            
end            
end            
            
if not exists(select 1 from AMS_LeadRatings where                   
AssessmentYearID = @AssessmentYearID and  AssessmentModeID = @AssessmentModeID  AND
UserInfoID = @ratingUserID and RatingUserID = @UserInfoID)                          
begin                          
                          
select LeadPerformanceID,                          
RatingName,                          
RatingDescription,                        
''  as SA,  
'' AS Comments  
from AMS_LeadPerformance                        
                        
end                          
else                        
begin                        
                        
select GR.LeadPerformanceID,    
GP.RatingName,                        
GP.RatingDescription,                        
GR.Rating as SA,  
GR.Comments  
from AMS_LeadRatings GR inner join AMS_LeadPerformance GP                        
on GR.LeadPerformanceID = GP.LeadPerformanceID    
where GR.AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID AND
GR.UserInfoID = @ratingUserID  and GR.RatingUserID = @UserInfoID                     
                        
end                        
                        
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeadRatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AMS_Get_LeadRatingsForDS]            
@AssessmentYearID INT,                  
@AssessmentModeID int,
@EmployeeID INT = -1
as            
begin            
            
if exists (select 1 from AMS_LeadRatings where AssessmentYearID = @AssessmentYearID 
and AssessmentModeID = @AssessmentModeID and UserInfoID = @EmployeeID)    
begin    
DECLARE @columns NVARCHAR(MAX) = '';                  
                  
SELECT @columns += QUOTENAME(A.FullName) + ','                  
FROM (SELECT DISTINCT U.FullName FROM AMS_LeadRatings GR                  
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID                  
where GR.AssessmentYearID= @AssessmentYearID           
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID and RatingUserID <> @EmployeeID) as A                  
ORDER BY A.FullName;                  
                  
IF(ISNULL(@columns,'') <> '')  
BEGIN  
SET @columns = LEFT(@columns, LEN(@columns) - 1);                  
PRINT @columns;                  
declare @sql NVARCHAR(MAX) = '';                  
                  
SET @sql ='                  
SELECT * FROM                     
(                  
SELECT            
GR.LeadPerformanceID,                  
GP.RatingName,                  
GP.RatingDescription,            
CAST(S.SA AS DECIMAL(18,2)) AS SA,        
CAST(M.MA AS DECIMAL(18,2)) AS MA,        
U.FullName,                  
GR.Rating                  
from AMS_LeadRatings GR                   
inner join AMS_LeadPerformance GP on GR.LeadPerformanceID = GP.LeadPerformanceID    
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID            
INNER JOIN (SELECT LeadPerformanceID,Rating AS SA             
FROM AMS_LeadRatings WHERE AssessmentYearID = ' + CAST(@AssessmentYearID AS VARCHAR) +'            
and AssessmentModeID = ' + cast(@AssessmentModeID as varchar) + '
 and UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + ' AND RatingUserID = ' + CAST(@EmployeeID AS VARCHAR) + ') S    
ON GR.LeadPerformanceID = S.LeadPerformanceID    
inner join (SELECT LeadPerformanceID, AVG(Rating) AS MA            
FROM AMS_LeadRatings WHERE AssessmentYearID = ' + CAST(@AssessmentYearID AS VARCHAR) + '    
and AssessmentModeID = ' + cast(@AssessmentModeID as varchar) + '
and UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + ' AND RatingUserID <> ' + 
CAST(@EmployeeID AS VARCHAR) +' group by LeadPerformanceID)M             
ON GR.LeadPerformanceID = M.LeadPerformanceID    
where GR.AssessmentYearID = ' +CAST(@AssessmentYearID  AS VARCHAR) +'             
and GR.AssessmentModeID =  ' + cast(@AssessmentModeID as varchar) + '
and GR.UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + '             
and GR.RatingUserID <> ' + CAST(@EmployeeID AS VARCHAR) + '                   
) t                   
PIVOT(                  
    max(Rating)                   
    FOR FullName IN ('+ @columns +')                  
) AS pivot_table;';                  
                  
                  
EXECUTE sp_executesql @sql;    
END  
ELSE  
BEGIN  
  
SELECT            
GR.LeadPerformanceID,                  
GP.RatingName,                  
GP.RatingDescription,            
CAST(S.SA AS DECIMAL(18,2)) AS SA,        
CAST(M.MA AS DECIMAL(18,2)) AS MA  
from AMS_LeadRatings GR                   
inner join AMS_LeadPerformance GP on GR.LeadPerformanceID = GP.LeadPerformanceID    
  
LEFT JOIN (SELECT LeadPerformanceID,Rating AS SA             
FROM AMS_LeadRatings WHERE AssessmentYearID = @AssessmentYearID  
and AssessmentModeID = @AssessmentModeID
 and UserInfoID = @EmployeeID  AND RatingUserID = @EmployeeID) S    
ON GR.LeadPerformanceID = S.LeadPerformanceID    
  
LEFT join (SELECT LeadPerformanceID, AVG(Rating) AS MA            
FROM AMS_LeadRatings WHERE AssessmentYearID = @AssessmentYearID  
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID  AND RatingUserID <> @EmployeeID group by LeadPerformanceID)M             
ON GR.LeadPerformanceID = M.LeadPerformanceID    
  
where GR.AssessmentYearID = @AssessmentYearID  
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID   
and GR.RatingUserID = @EmployeeID  
  
END  
    
DECLARE @SComments NVARCHAR(MAX)                                    
  SELECT @SComments =                                     
  COALESCE(@SComments + ',','') + CAST(Comments AS VARCHAR(max))    
  FROM (SELECT Comments FROM AMS_LeadRatings    
  where AssessmentYearID = @AssessmentYearID     
  and AssessmentModeID = @AssessmentModeID
  and UserInfoID = @EmployeeID  and RatingUserID = @EmployeeID) AS A      
      
  DECLARE @MComments NVARCHAR(MAX)                                    
  SELECT @MComments =                                     
  COALESCE(@MComments + ',','') + CAST(Comments AS VARCHAR(max))      
  FROM (SELECT Comments FROM AMS_LeadRatings    
  where AssessmentYearID = @AssessmentYearID    
  and AssessmentModeID = @AssessmentModeID
  and UserInfoID = @EmployeeID and RatingUserID <> @EmployeeID ) AS A      
    
    
select REPLACE(@SComments,',',CHAR(10) + CHAR(13)) AS SelfComments,    
REPLACE(@MComments,',',CHAR(10) + CHAR(13)) AS ManagementComments    
                
end                
            
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveDetailsByID]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeaveDetailsByID]  
@EmployeeLeaveID int  
as  
begin  
  
DECLARE @LeadIDs nvarchar(100)  
  
set @LeadIDs = (SELECT STUFF  
(  
    (  
        SELECT ',' + cast(s.LeadID as nvarchar)  
        FROM AMS_LeaveApproval s where EmoloyeeLeaveID = @EmployeeLeaveID  
        ORDER BY s.LeadID FOR XML PATH('')  
    ),  
     1, 1, ''  
) AS Employees)  
  
select   
EmployeeLeaveID,EmployeeID,LeaveTypeID,LeaveFromDate,LeaveToDate,  
LeaveReason,IsProjectDelivery,IsCompleted,ProjectPlan,  
EmergencyContact,LeaveCategoryID,LeaveDurationID,@LeadIDs AS Leads,
LeaveDays,FYearID
from AMS_EmployeeLeave   
where EmployeeLeaveID = @EmployeeLeaveID  
  
  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveDuration]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeaveDuration]
as
begin
select LookupID,LookupValue from AMS_Lookup where MapID = 4
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveHistory]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeaveHistory]        
@FYearID int,        
@EmployeeID int        
as        
begin        
        
select         
EL.EmployeeLeaveID,EL.LeaveTypeID,CONVERT(DATE, EL.LeaveFromDate) AS LeaveFromDate,  
CONVERT(DATE,EL.LeaveToDate) AS LeaveToDate,EL.LeaveReason,        
EL.IsProjectDelivery,        
case when EL.IsProjectDelivery = 1 then 'Yes' else 'No' end AS ProjectDeliveryText,        
EL.IsCompleted,        
case when EL.IsCompleted = 1 then 'Yes' else 'No' end AS CompletedText,        
EL.ProjectPlan,EL.EmergencyContact,EL.LeaveDays,        
EL.LeaveStatusID,EL.FYearID,EL.LeaveCategoryID,        
LT.LeaveTypeName,LS.LeaveStatusName,LC.LookupValue As LeaveCategory,      
LD.LookupValue AS LeaveDuration,EL.LeaveDurationID      
from AMS_EmployeeLeave EL         
inner join AMS_LeaveType LT on EL.LeaveTypeID = LT.LeaveTypeID        
inner join AMS_LeaveStatus LS on EL.LeaveStatusID = LS.LeaveStatusID        
inner join AMS_Lookup LC on EL.LeaveCategoryID = LC.LookupID        
inner join AMS_Lookup LD on EL.LeaveDurationID = LD.LookupID        
where EL.FYearID = @FYearID and EL.EmployeeID = @EmployeeID        
ORDER BY EL.LeaveFromDate DESC
        
select LA.EmoloyeeLeaveID,LA.LeadID,LA.LeadComments,        
CASE WHEN LA. ApprovalStatus = 9 THEN 'Approved'     
when LA.ApprovalStatus = 10 then 'Rejected' else    
'Approval Pending' end AS Approved,        
LA.ApprovalDate,U.FullName        
from AMS_LeaveApproval LA        
inner join AMS_EmployeeLeave EL  on LA.EmoloyeeLeaveID = EL.EmployeeLeaveID        
inner join AMS_UserInfo U on LA.LeadID = U.UserInfoID        
where EL.FYearID = @FYearID and EL.EmployeeID = @EmployeeID        
        
end    
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveHistoryForLead]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeaveHistoryForLead]            
@FYearID int  
as            
begin            
            
select             
EL.EmployeeLeaveID,EL.LeaveTypeID,CONVERT(DATE, EL.LeaveFromDate) AS LeaveFromDate,      
CONVERT(DATE,EL.LeaveToDate) AS LeaveToDate,EL.LeaveReason,            
EL.IsProjectDelivery,            
case when EL.IsProjectDelivery = 1 then 'Yes' else 'No' end AS ProjectDeliveryText,            
EL.IsCompleted,            
case when EL.IsCompleted = 1 then 'Yes' else 'No' end AS CompletedText,            
EL.ProjectPlan,EL.EmergencyContact,EL.LeaveDays,            
EL.LeaveStatusID,EL.FYearID,EL.LeaveCategoryID,            
LT.LeaveTypeName,LS.LeaveStatusName,LC.LookupValue As LeaveCategory,          
LD.LookupValue AS LeaveDuration,EL.LeaveDurationID,  
U.FullName  
from AMS_EmployeeLeave EL             
inner join AMS_LeaveType LT on EL.LeaveTypeID = LT.LeaveTypeID            
inner join AMS_LeaveStatus LS on EL.LeaveStatusID = LS.LeaveStatusID            
inner join AMS_Lookup LC on EL.LeaveCategoryID = LC.LookupID            
inner join AMS_Lookup LD on EL.LeaveDurationID = LD.LookupID            
INNER JOIN AMS_UserInfo U on EL.EmployeeID = U.UserInfoID  
where EL.FYearID = @FYearID and ISNULL(U.EmployeeStatus,1) = 1
ORDER BY EL.LeaveFromDate DESC  
  
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeavePlan]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeavePlan]
AS
BEGIN

select LookupID,LookupValue from AMS_Lookup where MapID = 3

END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeavesForApproval]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeavesForApproval]                
@EmployeeID int          
AS                
BEGIN                
          
select                 
EL.EmployeeLeaveID,EL.LeaveTypeID,    
CONVERT(DATE,EL.LeaveFromDate) AS LeaveFromDate,    
CONVERT(DATE,EL.LeaveToDate) AS LeaveToDate,EL.LeaveReason,          
EL.IsProjectDelivery,case when EL.IsProjectDelivery = 1 then 'Yes' else 'No' end AS ProjectDeliveryText,                
EL.IsCompleted,case when EL.IsCompleted = 1 then 'Yes' else 'No' end AS CompletedText,                
EL.ProjectPlan,EL.EmergencyContact,EL.LeaveDays,      
EL.LeaveStatusID,EL.FYearID,EL.LeaveCategoryID,      
LT.LeaveTypeName,LS.LeaveStatusName,LC.LookupValue As LeaveCategory,      
LD.LookupValue AS LeaveDuration,EL.LeaveDurationID,      
U.FullName AS EmployeeName,  
U.EMail  
from AMS_EmployeeLeave EL                 
inner join AMS_LeaveType LT on EL.LeaveTypeID = LT.LeaveTypeID                
inner join AMS_LeaveStatus LS on EL.LeaveStatusID = LS.LeaveStatusID                
inner join AMS_Lookup LC on EL.LeaveCategoryID = LC.LookupID                
inner join AMS_Lookup LD on EL.LeaveDurationID = LD.LookupID                
inner join AMS_LeaveApproval LA on EL.EmployeeLeaveID = LA.EmoloyeeLeaveID          
inner join AMS_UserInfo U on EL.EmployeeID = U.UserInfoID      
where LA.LeadID = @EmployeeID and ISNULL(LA.ApprovalStatus,0) = 0        
AND EL.LeaveStatusID = 5        
          
select LA.LeaveApprovalID, LA.EmoloyeeLeaveID,LA.LeadID,LA.LeadComments,                
CASE WHEN LA. ApprovalStatus = 9 THEN 'Approved'             
when LA.ApprovalStatus = 10 then 'Rejected' else            
'Approval Pending' end AS Approved,                
LA.ApprovalDate,U.FullName                
from AMS_LeaveApproval LA                
inner join (select EL.EmployeeLeaveID from AMS_EmployeeLeave EL           
inner join AMS_LeaveApproval LA on EL.EmployeeLeaveID = LA.EmoloyeeLeaveID          
where LA.LeadID = @EmployeeID and ISNULL(LA.ApprovalStatus,0) = 0 AND EL.LeaveStatusID = 5)          
EL  on LA.EmoloyeeLeaveID = EL.EmployeeLeaveID                
inner join AMS_UserInfo U on LA.LeadID = U.UserInfoID               
          
END 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LeaveType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LeaveType]  
@EmployeeID int
AS  
BEGIN  

declare @Gender bit = 0
select @Gender = Gender from AMS_UserInfo where UserInfoID = @EmployeeID

if(@Gender = 0)
select LeaveTypeID,LeaveTypeName from AMS_LeaveType  where LeaveTypeID <> 6
else
select LeaveTypeID,LeaveTypeName from AMS_LeaveType  where LeaveTypeID <> 7
  
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LiveHours]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LiveHours]    
@TimesheetID INT = 0,    
@EmployeeID int    
AS    
BEGIN    
    
DECLARE @DayMins int = 0    
IF(@TimesheetID <= 0)    
BEGIN    
select @TimesheetID = TimesheetID from AMS_TimeSheet                   
where EmployeeID = @EmployeeID                   
and CONVERT(date,LogDate) = CONVERT(date, dbo.AMS_GetLocalDate(GETUTCDATE()))    
END    
    
if(@TimesheetID <= 0)    
begin    
Set @DayMins = 0    
end    
else    
begin    
SELECT @DayMins =    
CASE WHEN T.LunchLogin IS NOT NULL AND T.LunchLogout IS NULL THEN DATEDIFF(MINUTE,T.DayLogin,T.LunchLogin) - ISNULL(T.BreakMins,0)    
WHEN D.DayBreakID IS NOT NULL THEN DATEDIFF(MINUTE,T.DayLogin,D.BreakLogin) - ISNULL(T.BreakMins,0)-
ISNULL(DATEDIFF(MINUTE,LunchLogin,LunchLogOut),0)    
WHEN T.DayLogout IS NULL THEN DATEDIFF(MINUTE,DayLogin,DBO.AMS_GetLocalDate(GETUTCDATE())) - ISNULL(T.BreakMins,0)-
ISNULL(DATEDIFF(MINUTE,LunchLogin,LunchLogOut),0)
ELSE T.DayMins END  
FROM AMS_TimeSheet T LEFT JOIN AMS_DayBreak D     
ON T.TimesheetID = D.TimesheetID  AND D.BreakLogin IS NOT NULL AND D.BreakLogout IS NULL    
WHERE T.TimesheetID = @TimesheetID    
end    
    
SELECT @TimesheetID,dbo.AMS_GetHours(@DayMins)    
    
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_LoginState]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_LoginState]            
@EmployeeID int,  
@TimeSheetID  int = 0            
AS            
begin            
            
declare @State char(10),@IsLunchCompleted char(10)='N',@IsDayCompleted char(10)='N' ,@IsBreakCompleted char(10)='N'        
        
if(@TimeSheetID <= 0)  
begin  
select @TimeSheetID  = TimesheetID from AMS_TimeSheet             
where EmployeeID = @EmployeeID             
and CONVERT(date,LogDate)  =CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))            
end  
            
if (@TimeSheetID = 0)        
begin        
set @State = 'DLI'        
end        
else        
begin        
        
if exists(select 1 from AMS_TimeSheet where TimesheetID = @TimeSheetID and DayLogout is null)            
set @State = 'DLO'            
        
if exists(select 1 from AMS_TimeSheet where TimesheetID = @TimeSheetID and LunchLogin is not null and LunchLogout is null)            
set @State = 'LLO'            
        
if exists(select 1 from AMS_DayBreak where TimesheetID = @TimeSheetID and BreakLogin is not null and BreakLogout is null)            
set @State = 'BLO'            
            
if exists(select 1 from AMS_TimeSheet where TimesheetID = @TimeSheetID and LunchLogin is not null and LunchLogout is not null)        
set @IsLunchCompleted = 'Y'            
          
if exists(select 1 from AMS_TimeSheet where TimesheetID = @TimeSheetID and DayLogin is not null and DayLogout is not null)          
set @IsDayCompleted = 'Y'          
      
declare @Count int = 0          
select @Count = COUNT(*) from AMS_DayBreak where TimesheetID = @TimeSheetID          
          
if(@Count >= 2)          
set @IsBreakCompleted = 'Y'      
End      
            
select @State,@IsLunchCompleted,@IsDayCompleted  ,@IsBreakCompleted      
          
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_MGoals]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[AMS_Get_MGoals]
@EmployeeID int,
@AssessmentYearID int,
@AssessmentModeID int
as
begin

select  
MGoalsAssessment,MGoalForYear,MGoalforHalfYear,MGoalForHalfYearDetails
from AMS_WorkPlaceRatingsComments 
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and EmployeeID = @EmployeeID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Project]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Project]        
as        
begin        
        
select P.ProjectID,P.ProjectName,      
U.UserInfoID,U.FullName,ISNULL(P.IsActive,0) as IsActive  
from AMS_Projects  P left join AMS_UserInfo U      
on P.ProjectLeadID = U.UserInfoID      
order by P.ProjectName
    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectDetails]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectDetails]
@ProjectID INT = 0
as
begin

SELECT ProjectID,ProjectName FROM AMS_Projects 
WHERE ProjectID = @ProjectID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectEmployee]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_ProjectEmployee]
@ProjectPhaseID int
as
begin
select
PE.ProjectEmployeeID,PE.ProjectID,PE.ProjectPhaseID,PE.EmployeeID,PE.JoiningDate,PE.IsActive,
PP.PhaseName,U.FullName,U1.FullName AS CreatedBy
from AMS_ProjectEmployee PE
inner join AMS_ProjectPhase PP on PE.ProjectPhaseID = PP.ProjectPhaseID
inner join AMS_UserInfo U on PE.EmployeeID = U.UserInfoID
inner join AMS_UserInfo U1 on PE.CreatedBy = U1.UserInfoID
where PE.ProjectPhaseID = @ProjectPhaseID
and ISNULL(U.EmployeeStatus,1) = 1
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectListForReport]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AMS_Get_ProjectListForReport]  
@LeadID int,
@RoleID int,
@IsActive Bit = 1  
as  
begin  

if(@RoleID = 1 OR @RoleID = 7 OR @RoleID = 6)
begin
select ProjectID,ProjectName from AMS_Projects  
where IsActive = @IsActive  
end
else
begin
select ProjectID,ProjectName from AMS_Projects  
where IsActive = @IsActive and ProjectLeadID = @LeadID
end

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectPhase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectPhase]      
@ProjectID INT = 0      
as      
begin      
      
SELECT ProjectID,ProjectPhaseID,    
PhaseName,U.FullName  AS CreatedBy,PP.CreatedDate,
IsActive
FROM AMS_ProjectPhase PP left join AMS_UserInfo U on PP.CreatedBy = U.UserInfoID    
WHERE ProjectID = @ProjectID    
      
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectRatingsByID]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectRatingsByID]                    
@ProjectUserMapID INT,                    
@UserInfoID INT                    
AS                    
Begin                    
                    
SELECT PU.ProjectID,              
UserInfoID,              
Selfcomments,              
ManagementComments,              
P.ProjectName,              
P.ProjectLeadID              
FROM AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID
AND ProjectUserMapID = @ProjectUserMapID
                    
if exists(select 1 from AMS_ProjectCriteriaMap where UserInfoID = @UserInfoID            
AND ProjectUserMapID = @ProjectUserMapID)
begin            
            
select  PC.CriteriaID,                  
c.CriteriaName,            
c.Description,            
Pc.Rating AS SA,        
PC.Comments        
from AMS_ProjectCriteriaMap PC            
inner join AMS_Criteria C on PC.CriteriaID = C.CriteriaID                    
where ProjectUserMapID = @ProjectUserMapID                     
and UserInfoID = @UserInfoID            

end            
            
else             
begin            
            
select  C.CriteriaID,                  
c.CriteriaName,            
c.Description,          
'' as SA,        
'' as Comments        
from            
AMS_Criteria C            

end            

END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectRatingsByIDForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectRatingsByIDForDS]            
@ProjectUserMapID INT,            
@UserInfoID INT = -1,            
@EmployeeID int = -1            
AS                        
Begin                        
        
DECLARE @SComments NVARCHAR(MAX)                                      
  SELECT @SComments =                                       
  COALESCE(@SComments + ',','') + CAST(Comments AS VARCHAR(max))        
  FROM (SELECT Comments FROM AMS_ProjectCriteriaMap PC        
  where ProjectUserMapID = @ProjectUserMapID         
  and UserInfoID = @EmployeeID) AS A        
        
  DECLARE @MComments NVARCHAR(MAX)                                      
  SELECT @MComments =                                       
  COALESCE(@MComments + ',','') + CAST(Comments AS VARCHAR(max))        
  FROM (SELECT Comments FROM AMS_ProjectCriteriaMap PC        
  where ProjectUserMapID = @ProjectUserMapID         
  and UserInfoID <> @EmployeeID) AS A        
        
                        
SELECT PU.ProjectID,                  
UserInfoID,                  
REPLACE(@SComments,',',char(10) + char(13)) AS Selfcomments,                  
REPLACE(@MComments,',',char(10) + char(13)) AS ManagementComments,                  
P.ProjectName,                  
Pu.ProjectLeadID                  
FROM AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID            
AND ProjectUserMapID = @ProjectUserMapID            
            
            
DECLARE @columns NVARCHAR(MAX) = '';                
                
SELECT @columns += QUOTENAME(A.FullName) + ','                
FROM (SELECT DISTINCT U.FullName FROM AMS_ProjectCriteriaMap PC            
inner join AMS_UserInfo U on PC.UserInfoID = U.UserInfoID                
where PC.ProjectUserMapID = @ProjectUserMapID and PC.UserInfoID <> @EmployeeID) as A                
ORDER BY A.FullName;                
PRINT @columns;                
  
if(ISNULL(@columns,'') <> '')  
begin  
  
SET @columns = LEFT(@columns, LEN(@columns) - 1);                         
declare @sql NVARCHAR(MAX) = '';                
                
SET @sql ='                
SELECT * FROM                   
(            
select  PC.CriteriaID,                      
c.CriteriaName,                
c.Description,                
PC.Rating,            
U.FullName,    
S.SA    
from AMS_ProjectCriteriaMap PC                
inner join AMS_Criteria C on PC.CriteriaID = C.CriteriaID                        
inner join AMS_UserInfo U on PC.UserInfoID = U.UserInfoID    
inner join (select CriteriaID,Rating As SA     
from AMS_ProjectCriteriaMap where ProjectUserMapID = ' +  cast(@ProjectUserMapID as varchar) + '    
and UserInfoID = ' + CAST(@EmployeeID as varchar) + ') S    
on PC.CriteriaID = S.CriteriaID where PC.ProjectUserMapID = ' + cast(@ProjectUserMapID as varchar) + '     
AND PC.UserInfoID <> ' + Cast(@EmployeeID as varchar) + ') t                 
PIVOT(                
    max(Rating)          
    FOR FullName IN ('+ @columns +')                
) AS pivot_table;';                
                
EXECUTE sp_executesql @sql;    
end  
  
else  
begin  
  
select  PC.CriteriaID,                      
c.CriteriaName,                
c.Description,                
PC.Rating AS SA,  
CAST(0 as decimal(18,2)) AS MA  
from AMS_ProjectCriteriaMap PC                
inner join AMS_Criteria C on PC.CriteriaID = C.CriteriaID                        
where PC.ProjectUserMapID = @ProjectUserMapID  
AND PC.UserInfoID = @EmployeeID  
  
end              
                        
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectRatingsfoMS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectRatingsfoMS]          
@AssessmentYearID INT,        
@AssessmentModeID INT,        
@EmployeeID int,  
@UserInfoID int  
  
as          
begin          
  
declare @ReportingLeadID INT = 0  
select @ReportingLeadID = ReportingLeadID from AMS_UserInfo where UserInfoID = @EmployeeID  
  
if(@UserInfoID = @ReportingLeadID)  
begin  
SELECT PU.ProjectUserMapID,    
PU.ProjectID,    
PU.UserInfoID,    
PU.Selfcomments,    
PU.ManagementComments,    
P.ProjectName,    
PL.FullName AS ProjectLead    
FROM  AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID    
inner join AMS_UserInfo PL on PU.ProjectLeadID = PL.UserInfoID    
WHERE PU.UserInfoID = @EmployeeID and AssessmentYearID = @AssessmentYearID 
and AssessmentModeID = @AssessmentModeID
end  
else  
begin  
  
SELECT PU.ProjectUserMapID,    
PU.ProjectID,    
PU.UserInfoID,    
PU.Selfcomments,    
PU.ManagementComments,    
P.ProjectName,    
PL.FullName AS ProjectLead    
FROM  AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID    
inner join AMS_UserInfo PL on PU.ProjectLeadID = PL.UserInfoID    
WHERE PU.UserInfoID = @EmployeeID 
and AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and PU.ProjectLeadID = @UserInfoID  
  
end  
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectsRatingMaster]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectsRatingMaster]                
as                
begin                
    
select FYearID AS AssessmentYearID,      
FYearName AS AssessmentYearName from AMS_FYear         
WHERE ISNULL(EnableAssessment,0) = 1      
    
select ProjectID ,ProjectName,ProjectLeadID from AMS_Projects where ISNULL(IsActive,0) = 1    
    
SELECT  CriteriaID,CriteriaName,Description FROM AMS_Criteria                
    
select UserInfoID,FullName from AMS_UserInfo where RoleID <> 4
  
select AssessmentModeID,AssessmentModeName from AMS_AssessmentMode  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectTask]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectTask]    
@ProjectID nvarchar(max)  
AS    
BEGIN    
    
select ET.EmployeeTaskID,ET.TaskHours AS TaskMins,ET.TaskDescription AS EmployeeTaskDescription,            
TS.LogDate,T.TaskDescription,ST.SubTaskDescription,WT.WorkTypedescription,              
dbo.AMS_GetHours(TaskHours) AS TaskHours,              
ET.TaskID,ET.SubTaskID,ET.WorkTypeID,    
U.FullName    
from AMS_EmployeeTask ET               
inner join AMS_TimeSheet TS on ET.TimesheetID = TS.TimesheetID              
inner join AMS_Task T on ET.TaskID = T.TaskID              
inner join dbo.SubTask() ST on ET.SubTaskID = ST.SubTaskID              
inner join (select distinct WorkTypeID,WorkTypedescription from dbo.WorkType()) WT on ET.WorkTypeID = WT.WorkTypeID    
inner join AMS_UserInfo U on ET.EmployeeID = U.UserInfoID    
where ET.SubTaskID in (select RTRIM(LTRIM(Item)) from dbo.SplitString(@ProjectID,','))  
order BY TS.LogDate desc      
    
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ProjectWorkType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ProjectWorkType]  
as      
begin      
select ProjectWorkTypeID,
WorkTypeDescription from AMS_ProjectWorkType  
order by WorkTypeDescription 
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_RatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_RatingsForDS]                        
@AssessmentYearID INT,           
@AssessmentModeID INT,      
@EmployeeID INT = -1    
AS                        
begin                        
                        
SELECT PU.ProjectUserMapID,                              
PU.ProjectID,                              
PU.UserInfoID,                              
PU.Selfcomments,                              
PU.ManagementComments,                              
P.ProjectName,                          
PL.FullName AS ProjectLead,                  
CAST(S.SA AS DECIMAL(18,2)) AS SA,                
CAST(M.MA AS DECIMAL(18,2)) AS MA              
FROM  AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID                              
inner join AMS_UserInfo PL on PU.ProjectLeadID = PL.UserInfoID                  
        
LEFT join (SELECT AVG(Rating) AS SA,ProjectUserMapID FROM AMS_ProjectCriteriaMap PC                  
WHERE EXISTS(SELECT 1 FROM AMS_ProjectUserMap PU                   
where PC.ProjectUserMapID = PU.ProjectUserMapID                   
and PU.AssessmentYearID  = @AssessmentYearID                   
and PU.AssessmentModeID = @AssessmentModeID      
and PU.UserInfoID = @EmployeeID)                  
and PC.UserInfoID = @EmployeeID GROUP BY ProjectUserMapID) S on PU.ProjectUserMapID = S.ProjectUserMapID       
        
LEFT join (select AVG(A.Rating) AS MA,A.ProjectUserMapID from                   
(SELECT AVG(Rating) as Rating,CriteriaID,ProjectUserMapID FROM AMS_ProjectCriteriaMap PC                  
WHERE EXISTS (SELECT 1 FROM AMS_ProjectUserMap PU                   
where PC.ProjectUserMapID = PU.ProjectUserMapID                   
and PU.AssessmentYearID  = @AssessmentYearID      
and PU.AssessmentModeID = @AssessmentModeID      
and PU.UserInfoID = @EmployeeID) and PC.UserInfoID <> @EmployeeID                  
GROUP BY CriteriaID,ProjectUserMapID) as A group by A.ProjectUserMapID) M on PU.ProjectUserMapID = M.ProjectUserMapID                  
        
WHERE PU.UserInfoID = @EmployeeID      
and AssessmentYearID = @AssessmentYearID      
and AssessmentModeID = @AssessmentModeID      
                      
if exists (select 1 from AMS_GenaralRatings where AssessmentYearID = @AssessmentYearID       
and AssessmentModeID = @AssessmentModeID and UserInfoID = @EmployeeID)                      
begin                      
DECLARE @columns NVARCHAR(MAX) = '';                        
                        
SELECT @columns += QUOTENAME(A.FullName) + ','       
FROM (SELECT DISTINCT U.FullName FROM AMS_GenaralRatings GR                        
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID                        
where GR.AssessmentYearID= @AssessmentYearID         
and GR.AssessmentModeID = @AssessmentModeID      
and GR.UserInfoID = @EmployeeID                   
AND GR.RatingUserID <> @EmployeeID) as A                  
ORDER BY A.FullName;                        
            
PRINT @columns             
            
IF(ISNULL(@columns,'') <> '' )            
BEGIN            
SET @columns = LEFT(@columns, LEN(@columns) - 1);                        
declare @sql NVARCHAR(MAX) = '';                        
                        
SET @sql ='                        
SELECT * FROM                           
(                        
SELECT                  
GR.GeneralPerformanceID,                        
GP.RatingName,                        
GP.RatingDescription,                  
CAST(S.SA AS DECIMAL(18,2)) AS SA,                
CAST(M.MA AS DECIMAL(18,2)) AS MA,                
U.FullName,                        
GR.Rating                        
from AMS_GenaralRatings GR                         
inner join AMS_GeneralPerformance GP on GR.GeneralPerformanceID = GP.GeneralPerformanceID                        
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID                  
INNER JOIN (SELECT GeneralPerformanceID,Rating AS SA                   
FROM AMS_GenaralRatings WHERE AssessmentYearID = ' + CAST(@AssessmentYearID AS VARCHAR) 
+ ' and AssessmentModeID = ' + CAST(@AssessmentModeID AS VARCHAR) 
+ ' and UserInfoID = ' + CAST(@EmployeeID AS VARCHAR)       
+ ' AND RatingUserID = ' + CAST(@EmployeeID AS VARCHAR) + ') S                   
ON GR.GeneralPerformanceID = S.GeneralPerformanceID                  
inner join (SELECT GeneralPerformanceID, AVG(Rating) AS MA       
FROM AMS_GenaralRatings WHERE AssessmentYearID = ' + CAST(@AssessmentYearID AS VARCHAR) 
+ 'and AssessmentModeID = ' + CAST(@AssessmentModeID AS VARCHAR) 
+ ' and UserInfoID = ' + CAST(@EmployeeID AS VARCHAR)       
+ ' AND RatingUserID <> ' + CAST(@EmployeeID AS VARCHAR) +' group by GeneralPerformanceID)M                   
ON GR.GeneralPerformanceID = M.GeneralPerformanceID                  
where GR.AssessmentYearID = ' +CAST(@AssessmentYearID  AS VARCHAR) +      
' and GR.UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + '                   
and GR.RatingUserID <> ' + CAST(@EmployeeID AS VARCHAR) + '                         
) t                         
PIVOT(             
    max(Rating)                         
    FOR FullName IN ('+ @columns +')                        
) AS pivot_table;';                        
EXECUTE sp_executesql @sql;                        
END            
ELSE            
BEGIN            
            
SELECT                  
GR.GeneralPerformanceID,                        
GP.RatingName,                        
GP.RatingDescription,                  
CAST(S.SA AS DECIMAL(18,2)) AS SA,                
CAST(M.MA AS DECIMAL(18,2)) AS MA            
from AMS_GenaralRatings GR                         
inner join AMS_GeneralPerformance GP on GR.GeneralPerformanceID = GP.GeneralPerformanceID                        
            
LEFT JOIN (SELECT GeneralPerformanceID,Rating AS SA                   
FROM AMS_GenaralRatings WHERE AssessmentYearID = @AssessmentYearID            
 and UserInfoID = @EmployeeID AND RatingUserID = @EmployeeID ) S            
ON GR.GeneralPerformanceID = S.GeneralPerformanceID                  
            
LEFT join (SELECT GeneralPerformanceID, AVG(Rating) AS MA                  
FROM AMS_GenaralRatings WHERE AssessmentYearID = @AssessmentYearID            
and UserInfoID = @EmployeeID  AND RatingUserID <> @EmployeeID  group by GeneralPerformanceID)M                   
ON GR.GeneralPerformanceID = M.GeneralPerformanceID                  
            
where GR.AssessmentYearID = @AssessmentYearID              
and GR.UserInfoID = @EmployeeID             
and GR.RatingUserID = @EmployeeID            
            
END            
end                      
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ReportingEmployees]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ReportingEmployees]
@ReportingLeadID int
as
begin
select UserInfoID,FullName from AMS_UserInfo 
where ReportingLeadID = @ReportingLeadID
and ISNULL(EmployeeStatus,1) = 1  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ReportingLeads]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ReportingLeads]
as
begin

select UserInfoID As ReportingLeadID,
FullName AS ReportingLead 
from AMS_UserInfo where RoleID in (1,3,6,7)

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Requirement]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Requirement]
@ProjectPhaseID int        
as        
begin        
        
select  R.ComponentID,R.RequirementID,CP.ComponentName,R.RequirementName,
R.RDescription,C.FullName As CreatedBy,R.CreatedDate,
U.FullName AS LastUpdatedBy ,R.LastUpdatedDate
from AMS_Requirement R
inner join AMS_Component CP on R.ComponentID = CP.ComponentID
left join AMS_UserInfo C on R.CreatedBy = C.UserInfoID
left join AMS_UserInfo U on R.LastUpdatedBy = U.UserInfoID
where CP.ProjectPhaseID = @ProjectPhaseID  and ISNULL(Status,1) = 1

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_RequirementDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_RequirementDescription]
@RequirementID INT = 0  
AS  
  
BEGIN  
  
SELECT Description FROM AMS_RequirementDescription
WHERE RequirementID = @RequirementID
  
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_RequirementForDropDown]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_RequirementForDropDown]  
@ComponentID int          
as          
begin          
          
select  R.RequirementID,R.RequirementName
from AMS_Requirement R
where ComponentID = @ComponentID
          
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Role]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Role]
as
begin
select RoleID,RoleName from AMS_Role
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Scenario]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Scenario]    
@ProjectPhaseID int      
as                
begin                
                
select S.ScenarioID,S.ShortDescription,   
R.ComponentID,R.RequirementID,CP.ComponentName,R.RequirementName,  
R.RDescription,C.FullName As CreatedBy,S.CreatedDate,        
U.FullName AS LastUpdatedBy ,S.LastUpdatedDate        
from AMS_Scenario S
inner join AMS_Requirement R on S.RequirementID = R.RequirementID    
inner join AMS_Component CP on R.ComponentID = CP.ComponentID        
left join AMS_UserInfo C on S.CreatedBy = C.UserInfoID        
left join AMS_UserInfo U on S.LastUpdatedBy = U.UserInfoID        
where CP.ProjectPhaseID = @ProjectPhaseID  and ISNULL(CP.Status,1) = 1        
        
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ScenarioDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ScenarioDescription]  
@ScenarioID INT = 0    
AS    
    
BEGIN    
    
SELECT ScenarioDescription FROM AMS_ScenarioDescription
WHERE ScenarioID = @ScenarioID
    
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_ScenarioForDropDown]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_ScenarioForDropDown]    
@RequirementID int            
as            
begin            
            
select  ScenarioID,ShortDescription
from AMS_Scenario where RequirementID = @RequirementID
            
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_SelfGoals]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[AMS_Get_SelfGoals]
@EmployeeID int,
@AssessmentYearID int,
@AssessmentModeID int
as
begin

select  
AchivedGoals,SelfGoalForYear,SelfGoalforHalfYear,SelfGoalForHalfYearDetails
from AMS_WorkPlaceRatingsComments 
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and EmployeeID = @EmployeeID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_SubTask]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_SubTask]  
as  
begin  
  
select ST.SubTaskID,ST.SubTaskDescription,T.TaskID,T.TaskDescription   
from AMS_SubTask ST inner join AMS_Task T  
on ST.TaskID = T.TaskID  
order by ST.SubTaskDescription
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Task]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Task]    
as    
begin    
select TaskID,TaskDescription from AMS_Task  where TaskID <> 5 
order by TaskDescription
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TaskMaster]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TaskMaster]          
AS          
BEGIN          
          
SELECT TaskID,TaskDescription FROM AMS_Task order by TaskDescription   
select * from dbo.SubTask() order by SubTaskDescription  
select * from dbo.WorkType() order by WorkTypedescription  
       
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TechnicalRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TechnicalRatings]          
@AssessmentYearID int,          
@UserInfoID int ,                
@ratingUserID int,
@AssessmentModeID INT
AS                          
begin                          
            
if(@UserInfoID <> @ratingUserID)            
begin            
if not exists(select 1 from AMS_TechnicalRatings          
where AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID
and UserInfoID = @ratingUserID)            
begin            
return;            
end            
end            
    
declare @DesignationID int = 0      
select @DesignationID = DesignationID from AMS_UserInfo where UserInfoID = @ratingUserID    
            
if not exists(select 1 from AMS_TechnicalRatings where                   
AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID AND 
UserInfoID = @ratingUserID and RatingUserID = @UserInfoID)                          
begin                          
    
if(@DesignationID = 3)    
begin    
    
select TechnicalPerformanceID,                          
RatingName,                          
RatingDescription,                        
''  as SA                        
from AMS_TechnicalPerformance  where ISCRM = 1    
    
end    
else if(@DesignationID = 7)    
begin    
    
select TechnicalPerformanceID,                          
RatingName,                          
RatingDescription,                        
''  as SA                        
from AMS_TechnicalPerformance  where ISHR = 1    
    
end    
    
else     
begin    
select TechnicalPerformanceID,                          
RatingName,                          
RatingDescription,                        
''  as SA                        
from AMS_TechnicalPerformance where IsEmployee = 1    
end    
                        
end                          
else                        
begin                        
                        
select GR.TechnicalPerformanceID,                        
GP.RatingName,                        
GP.RatingDescription,                        
GR.Rating as SA from AMS_TechnicalRatings GR inner join AMS_TechnicalPerformance GP                        
on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID          
where GR.AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID AND
GR.UserInfoID = @ratingUserID  and GR.RatingUserID = @UserInfoID                     
                        
end                        
                        
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TechnicalRatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AMS_Get_TechnicalRatingsForDS]            
@AssessmentYearID INT,                  
@AssessmentModeID int,
@EmployeeID INT = -1
as            
begin            
            
if exists (select 1 from AMS_TechnicalRatings     
where AssessmentYearID = @AssessmentYearID     
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID)                
begin                
    
DECLARE @columns NVARCHAR(MAX) = '';                  
SELECT @columns += QUOTENAME(A.FullName) + ','                  
FROM (SELECT DISTINCT U.FullName FROM AMS_TechnicalRatings GR                  
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID                  
where GR.AssessmentYearID= @AssessmentYearID  
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID and RatingUserID <> @EmployeeID) as A                  
ORDER BY A.FullName;                  
    
IF(ISNULL(@columns,'') <> '')                  
BEGIN    
SET @columns = LEFT(@columns, LEN(@columns) - 1);                  
PRINT @columns;                  
declare @sql NVARCHAR(MAX) = '';                  
SET @sql ='                  
SELECT * FROM                     
(                  
SELECT            
GR.TechnicalPerformanceID,                  
GP.RatingName,                  
GP.RatingDescription,            
CAST(S.SA AS DECIMAL(18,2)) AS SA,        
CAST(M.MA AS DECIMAL(18,2)) AS MA,        
U.FullName,                  
GR.Rating                  
from AMS_TechnicalRatings GR                   
inner join AMS_TechnicalPerformance GP on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID                  
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID            
INNER JOIN (SELECT TechnicalPerformanceID,Rating AS SA             
FROM AMS_TechnicalRatings WHERE AssessmentYearID = ' + CAST(@AssessmentYearID AS VARCHAR) +'
and AssessmentModeID = ' + cast(@AssessmentModeID as varchar) + '
 and UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + ' AND RatingUserID = ' + CAST(@EmployeeID AS VARCHAR) + ') S             
ON GR.TechnicalPerformanceID = S.TechnicalPerformanceID            
inner join (SELECT TechnicalPerformanceID, AVG(Rating) AS MA            
FROM AMS_TechnicalRatings WHERE AssessmentYearID = ' + CAST(@AssessmentYearID AS VARCHAR) + '
and AssessmentModeID = ' + cast(@AssessmentModeID as varchar) + '
and UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + ' AND RatingUserID <> ' + 
CAST(@EmployeeID AS VARCHAR) +' group by TechnicalPerformanceID)M             
ON GR.TechnicalPerformanceID = M.TechnicalPerformanceID            
where GR.AssessmentYearID = ' +CAST(@AssessmentYearID  AS VARCHAR) +'             
and GR.AssessmentModeID = ' + cast(@AssessmentModeID as varchar) + '
and GR.UserInfoID = ' + CAST(@EmployeeID AS VARCHAR) + '             
and GR.RatingUserID <> ' + CAST(@EmployeeID AS VARCHAR) + '                   
) t                   
PIVOT(                  
    max(Rating)                   
    FOR FullName IN ('+ @columns +')                  
) AS pivot_table;';                  
                  
                  
EXECUTE sp_executesql @sql;                  
END    
ELSE    
BEGIN    
    
SELECT            
GR.TechnicalPerformanceID,                  
GP.RatingName,                  
GP.RatingDescription,            
CAST(S.SA AS DECIMAL(18,2)) AS SA,        
CAST(M.MA AS DECIMAL(18,2)) AS MA    
from AMS_TechnicalRatings GR                   
inner join AMS_TechnicalPerformance GP on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID                  
    
LEFT JOIN (SELECT TechnicalPerformanceID,Rating AS SA             
FROM AMS_TechnicalRatings WHERE AssessmentYearID = @AssessmentYearID    
and AssessmentModeID = @AssessmentModeID
 and UserInfoID = @EmployeeID  AND RatingUserID = @EmployeeID) S             
ON GR.TechnicalPerformanceID = S.TechnicalPerformanceID            
    
LEFT JOIN (SELECT TechnicalPerformanceID, AVG(Rating) AS MA            
FROM AMS_TechnicalRatings WHERE AssessmentYearID = @AssessmentYearID    
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID group by TechnicalPerformanceID)M             
ON GR.TechnicalPerformanceID = M.TechnicalPerformanceID            
    
where GR.AssessmentYearID = @AssessmentYearID    
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID    
and GR.RatingUserID = @EmployeeID    
    
END             
end                
            
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Testcase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Testcase]    
@ProjectPhaseID int        
as                  
begin                  
    
select    
T.TestcaseID,T.TestcaseName,
T.Severity,
case when T.Severity = 1 then 'Major' else 'Minor' end as SeverityDesc,
 T.Complexity,
case when T.Complexity = 1 then 'High' else 'Low' end as ComplexityDesc,
 T.TestcaseType,
 case when T.TestcaseType = 1 then  'Positive' else 'Negative' end as TestcaseTypeDesc,
 T.RegressionRequired,  
S.ScenarioID,S.ShortDescription, R.ComponentID,  
R.RequirementID,CP.ComponentName,R.RequirementName,          
R.RDescription,C.FullName As CreatedBy,R.CreatedDate,          
U.FullName AS LastUpdatedBy ,R.LastUpdatedDate          
from AMS_Testcase T    
inner join  AMS_Scenario S  on T.ScenarioID = S.ScenarioID    
inner join AMS_Requirement R on S.RequirementID = R.RequirementID      
inner join AMS_Component CP on R.ComponentID = CP.ComponentID          
left join AMS_UserInfo C on T.CreatedBy = C.UserInfoID          
left join AMS_UserInfo U on T.LastUpdatedBy = U.UserInfoID          
where CP.ProjectPhaseID = @ProjectPhaseID    
          
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestcaseDescription]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TestcaseDescription]    
@TestcaseID INT = 0      
AS      
      
BEGIN      
      
SELECT TestSteps,ExpectedResult FROM AMS_TestcaseDescription
WHERE TestcaseID = @TestcaseID
      
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestcaseDetails]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TestcaseDetails]    
@TestExecutionID int    
as    
begin    
    
select            
TE.TestExecutionID,T.TestcaseID,T.TestcaseName,       
T.Severity,T.Complexity,T.TestcaseType,    
T.RegressionRequired,TD.TestSteps,TD.ExpectedResult,      
S.ScenarioID,S.ShortDescription As Scenario,TE.Testdata,      
TE.Testdate,U.FullName as Testedby,TE.TestStatus,TE.Comments,  
R.RequirementName,C.ComponentName  
  
from AMS_TestExecution TE inner join AMS_Testcase T  on TE.TestcaseID = T.TestcaseID      
inner join AMS_TestcaseDescription TD on TE.TestcaseID = TD.TestcaseID      
inner join  AMS_Scenario S  on T.ScenarioID = S.ScenarioID      
inner join AMS_Requirement R on S.RequirementID = R.RequirementID  
inner join AMS_Component C on R.ComponentID = C.ComponentID  
left join AMS_UserInfo U on TE.Testedby = U.UserInfoID  
where TE.TestExecutionID = @TestExecutionID    
    
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestExecution]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TestExecution]      
@DevBuildID int      
as      
begin      
      
select            
TE.TestExecutionID,T.TestcaseID,T.TestcaseName,       
T.Severity,case when T.Severity = 1 then 'Major' else 'Minor' end as SeverityDesc,        
T.Complexity,case when T.Complexity = 1 then 'High' else 'Low' end as ComplexityDesc,        
T.TestcaseType,case when T.TestcaseType = 1 then  'Positive' else 'Negative' end as TestcaseTypeDesc,        
T.RegressionRequired,TD.TestSteps,TD.ExpectedResult,      
S.ScenarioID,S.ShortDescription As Scenario,TE.Testdata,      
TE.Testdate,U.FullName AS Testedby,      
TE.TestStatus,    
case when TE.TestStatus = 0 then 'Failed'       
when TE.TestStatus = 1 then 'Passed' else null end as TestStatusDesc,    
TE.Comments      
from AMS_TestExecution TE inner join AMS_Testcase T  on TE.TestcaseID = T.TestcaseID      
left join AMS_TestcaseDescription TD on TE.TestcaseID = TD.TestcaseID      
left join  AMS_Scenario S  on T.ScenarioID = S.ScenarioID      
left join AMS_UserInfo U on TE.Testedby = U.UserInfoID  
where TE.DevBuildID = @DevBuildID      
      
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TestExecutionLog]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TestExecutionLog]
@TestExecutionID int        
as        
begin        
        
select              
TE.Testdata,        
TE.Testdate,
U.FullName AS Testedby,        
TE.TestStatus,      
case when TE.TestStatus = 0 then 'Failed'         
when TE.TestStatus = 1 then 'Passed' else null end as TestStatusDesc,      
TE.Comments
from AMS_TestExecutionLog TE
left join AMS_UserInfo U on TE.Testedby = U.UserInfoID 
where TE.TestExecutionID = @TestExecutionID
    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_Timesheet]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_Timesheet]      
@EmployeeID INT = 0,                                      
@SelectedMonth date                                      
as                                                                  
begin                                                                  
      
declare @TodayID int = CAST(YEAR(dbo.AMS_GetLocalDate(getutcDate())) AS varchar(4))      
+ RIGHT('0' + CAST(DAY(dbo.AMS_GetLocalDate(getutcDate())) AS varchar(2)),2)      
+ RIGHT('0' + CAST(MONTH(dbo.AMS_GetLocalDate(getutcDate())) AS varchar(2)),2)      
      
DECLARE @mydate DATETIME = @SelectedMonth                                    
Declare @Days Table (ID int identity(1,1) not null,                   
DateField datetime,                   
DayField int,                  
DayNme nvarchar(50),                  
DayID int)                    
Declare @CurrentDate datetime                                              
Declare @EndDate datetime                                              
                                              
SELECT @CurrentDate = DATEADD(dd,-(DAY(@mydate)-1),@mydate)                                              
SELECT @EndDate =DATEADD(dd,-(DAY(DATEADD(mm,1,@mydate))),DATEADD(mm,1,@mydate))                                              
                                              
While @CurrentDate <= @EndDate                                              
Begin                                              
 Insert Into @Days                     
 Values(@CurrentDate,                    
 DATEPART(dw, @CurrentDate),                    
 DATENAME(dw , @CurrentDate),                    
 cast(YEAR(@CurrentDate) AS varchar(4)) +         
RIGHT('0' + cast(DAY(@CurrentDate) AS varchar(2)),2) +           
RIGHT('0' + cast(MONTH(@CurrentDate) AS varchar(2)),2))        
 Set @CurrentDate = DateAdd(d,1,@CurrentDate)                                              
End                                              
      
CREATE TABLE #tDetails(                                              
ID int,                                              
TimesheetID int,                                                    
LogDate datetime,                                                            
DayLogin datetime,                                                            
LunchLogin datetime,                                                            
LunchLogout datetime,                                                            
DayLogout datetime,                                                                  
DayHours nvarchar(50),                                                    
LunchHours nvarchar(50),                                                        
BreakHours nvarchar(50),                              
DayMins int,                    
DayID int,                
DayField int,                    
DayNme nvarchar(50))                              
                                                    
INSERT INTO #tDetails                                                    
select                                                
T.ID,                                              
S.TimesheetID,                                              
T.DateField AS LogDate,                                              
S.DayLogin,                                              
S.LunchLogin,                                              
S.LunchLogout,                                              
S.DayLogout,                                              
S.DayHours,                                              
S.LunchHours,                                              
S.BreakHours,                              
S.DayMins,                    
T.DayID,                  
T.DayField,                    
T.DayNme                    
from @Days T left join (                                              
SELECT                                               
T.TimesheetID,                                                             
T.LogDate,                                    
T.DayLogin,                                    
T.LunchLogin,                                    
T.LunchLogout,       
T.DayLogout,                                       
dbo.AMS_GetHours(T.DayMins) as DayHours,                                    
dbo.AMS_GetHours(T.LunchMins) as LunchHours,                                    
dbo.AMS_GetHours(T.BreakMins) as BreakHours,                              
T.DayMins,                    
T.DayID                
FROM AMS_TimeSheet T WHERE T.EmployeeID = @EmployeeID) S                   
on T.DayID = S.DayID                
      
SELECT ID ,                                              
ISNULL(T.TimesheetID,-1) as TimesheetID,                                            
LogDate,                                              
case                                 
WHEN H.HolidayID IS NOT NULL THEN CONVERT(varchar, LogDate, 105) + '(' + H.HolidayName + ')'                                              
when (DayField = 7 OR DayField = 1) then CONVERT(varchar, LogDate, 105) + '(' + DayNme + ')'                    
else CONVERT(varchar, LogDate, 105)                    
end AS LogDateDesc,                    
DayLogin,                    
LunchLogin,                    
LunchLogout,                    
DayLogout,                    
DayHours,                    
LunchHours,                    
BreakHours,                    
case when H.HolidayID is null then 0 else 1 end as IsHoliday,                             
case when (DayField = 7 OR DayField = 1) then 1 else 0 end AS IsWeekend,      
      
case when T.DayID = @TodayID then 0      
WHEN ISNULL(T.DayMins,0) <> ISNULL(ET.TaskMins,0) THEN 1 ELSE 0 END AS Editable      
FROM #tDetails T left join AMS_HoliDay H ON T.DayID = H.DayID      
LEFT JOIN (SELECT TimesheetID,SUM(TaskHours) AS TaskMins FROM AMS_EmployeeTask group by TimesheetID) ET      
on T.TimesheetID = ET.TimesheetID      
ORDER BY ID
                    
select                                              
TS.ID,                                            
E.TimesheetID,                                                            
E.TaskDescription as EmployeeTaskDescription,                                                            
E.TaskHours As TaskMins,                                              
dbo.AMS_GetHours(TaskHours) as TaskHours,                                                        
T.TaskDescription,                                                            
St.SubTaskDescription,                                                            
W.WorkTypedescription                                              
from AMS_EmployeeTask E                                                             
inner join AMS_Task T on E.TaskID = T.TaskID                                                            
inner join dbo.SubTask() ST on E.SubTaskID = ST.SubTaskID                                                            
inner join (select Distinct WorkTypeID,WorkTypedescription from  dbo.WorkType()) W on E.WorkTypeID = W.WorkTypeID                                              
inner join #tDetails TS on E.TimesheetID = TS.TimesheetID
            
SELECT             
            
D.TimesheetID,            
D.DayBreakID,                       
D.BreakLogin,                      
D.BreakLogout,                       
dbo.AMS_GetHours(D.BreakMins) AS BreakMins            
FROM AMS_DayBreak D WHERE EXISTS             
(SELECT T.TimesheetID FROM #tDetails T WHERE T.TimesheetID = D.TimesheetID)            
                                                               
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TimesheetDetails]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_TimesheetDetails]        
@TimesheetID int = 0        
AS        
begin        
        
select  TimesheetID,
LogDate,
DayLogin,        
DayLogout,
LunchLogin,
LunchLogout
from AMS_TimeSheet where TimesheetID = @TimesheetID        
        
select DayBreakID,
BreakLogin, 
BreakLogout from AMS_DayBreak         
where TimesheetID = @TimesheetID        
        
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TodayHours]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TodayHours]                      
@EmployeeID int = 0,      
@TimesheetID INT = 0,  
@ISEdit bit  
as                      
begin                      
            
declare @LogOutTime Datetime = dbo.AMS_GetLocalDate(GETUTCDATE())        
IF(@TimesheetID <= 0)      
begin      
select @TimesheetID = TimesheetID from AMS_TimeSheet                       
where EmployeeID = @EmployeeID                       
and CONVERT(date,LogDate) = CONVERT(date,@LogOutTime)            
end      
  
if (@ISEdit = 0)  
begin  
select  DATEDIFF(MINUTE,DayLogin,@LogoutTime) -                
ISNULL(LunchMins,0) -                       
ISNULL(BreakMins,0),            
@LogOutTime as LogoutTime,
0 AS TaskMins from AMS_TimeSheet                       
where TimesheetID = @TimesheetID                      
end  
else  
begin  
declare @TaskMins int = 0

select @TaskMins = ISNULL(sum(TaskHours),0) from AMS_EmployeeTask where TimesheetID = @TimesheetID

select DayMins,@LogOutTime as LogoutTime,@TaskMins As TaskMins from AMS_TimeSheet   
where TimesheetID = @TimesheetID  
end  
                      
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TotalHours]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TotalHours]                  
@EmployeeID int                  
as                  
begin                  
                  
CREATE TABLE #THours(HoursDesc nvarchar(100),TotalHours nvarchar(10),LoggedHours nvarchar(10))                  
            
DECLARE @mydate DATETIME  
set @mydate = dbo.AMS_GetLocalDate(GETUTCDATE())  
Declare @Days Table (ID int identity(1,1) not null, DateField datetime, DayField varchar(50))                
Declare @CurrentDate datetime                
Declare @EndDate datetime                
                
SELECT @CurrentDate = DATEADD(dd,-(DAY(@mydate)-1),@mydate)                
SELECT @EndDate =DATEADD(dd,-(DAY(DATEADD(mm,1,@mydate))),DATEADD(mm,1,@mydate))                
                
While @CurrentDate <= @EndDate                
Begin                
Insert Into @Days Values(@CurrentDate, DATENAME(dw , @CurrentDate))                
Set @CurrentDate = DateAdd(d,1,@CurrentDate)                
End              
              
CREATE TABLE #tDetails(                
ID int,                
TimesheetID int,                      
LogDate datetime,                              
DayLogin datetime,                              
LunchLogin datetime,                              
LunchLogout datetime,                              
DayLogout datetime,                                    
DayMins int,               
LunchMins int,                          
BreakMins int)                      
              
              
INSERT INTO #tDetails                      
select                  
T.ID,                
S.TimesheetID,                
T.DateField AS LogDate,                
S.DayLogin,                
S.LunchLogin,                
S.LunchLogout,                
S.DayLogout,                
S.DayMins,                
S.LunchMins,                
S.BreakMins              
from @Days T left join (                
SELECT                 
T.TimesheetID,                               
T.LogDate,                              
T.DayLogin,                              
T.LunchLogin,                              
T.LunchLogout,                              
T.DayLogout,                                    
T.DayMins,                          
T.LunchMins,                          
T.BreakMins              
FROM AMS_TimeSheet T                
WHERE T.EmployeeID = @EmployeeID and Month(LogDate) = MONTH(dbo.AMS_GetLocalDate(GETUTCDATE()))) S                 
on CONVERT(date,T.DateField) = CONVERT(date,S.LogDate)            
            
insert into #THours(HoursDesc,TotalHours,LoggedHours)                  
SELECT             
'Today Hours',          
case when H.HolidayID is not null then 0            
when (DATEPART(dw, LogDate) = 7 OR DATEPART(dw, LogDate) = 1)  then 0            
else 480 end as Totalhours,            
case when T.DayLogin is null then 0  
when DayMins is null and LunchLogin is null then 0  
when DayMins is null and LunchLogin is not null   
THEN ISNULL(DATEDIFF(MINUTE,T.DayLogin,T.LunchLogin),0) - ISNULL(T.BreakMins,0)
else ISNULL(T.DayMins,0) end AS LoggedHours            
FROM #tDetails T left join AMS_HoliDay H               
on CONVERT(date,T.LogDate) = CONVERT(date,H.HolidayDate)             
where CONVERT(date,T.LogDate) = CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))  
            
insert into #THours(HoursDesc,TotalHours,LoggedHours)                  
SELECT             
'Weekly Hours',            
sum(case when H.HolidayID is not null then 0            
when (DATEPART(dw, LogDate) = 7 OR DATEPART(dw, LogDate) = 1)  then 0            
else 480 end) as Totalhours,            
SUM(ISNULL(DayMins,0)) AS LoggedHours          
FROM #tDetails T left join AMS_HoliDay H               
on CONVERT(date,T.LogDate) = CONVERT(date,H.HolidayDate)              
where DATEPART(wk, LogDate) = DATEPART(wk, dbo.AMS_GetLocalDate(GETUTCDATE()))
            
insert into #THours(HoursDesc,TotalHours,LoggedHours)                 
SELECT             
'Monthly Hours',            
sum(case when H.HolidayID is not null then 0            
when (DATEPART(dw, LogDate) = 7 OR DATEPART(dw, LogDate) = 1)  then 0            
else 480 end) as Totalhours,            
sum(ISNULL(DayMins,0)) AS LoggedHours          
FROM #tDetails T left join AMS_HoliDay H               
on CONVERT(date,T.LogDate) = CONVERT(date,H.HolidayDate)              
where Month(LogDate) = Month(dbo.AMS_GetLocalDate(GETUTCDATE()))  
            
select            
HoursDesc,            
dbo.AMS_GetHours(TotalHours) AS TotalHours,            
dbo.AMS_GetHours(LoggedHours) AS LoggedHours            
from #THours                
                  
end   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_TotalHours1]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_TotalHours1]                
@EmployeeID int,                
@SelectedMonth datetime                
as                                
begin                                
                                
CREATE TABLE #THours(HoursDesc nvarchar(100),TotalHours nvarchar(10),LoggedHours nvarchar(10))                                
                          
DECLARE @mydate DATETIME =  @SelectedMonth          
Declare @Days Table (ID int identity(1,1) not null, DateField datetime, DayField varchar(50))                              
Declare @CurrentDate datetime                              
Declare @EndDate datetime                              
                              
SELECT @CurrentDate = DATEADD(dd,-(DAY(@mydate)-1),@mydate)                              
SELECT @EndDate =DATEADD(dd,-(DAY(DATEADD(mm,1,@mydate))),DATEADD(mm,1,@mydate))                              
                              
While @CurrentDate <= @EndDate                              
Begin                              
Insert Into @Days Values(@CurrentDate, DATENAME(dw , @CurrentDate))                              
Set @CurrentDate = DateAdd(d,1,@CurrentDate)                              
End                            
                            
CREATE TABLE #tDetails(                              
ID int,                              
TimesheetID int,                                    
LogDate datetime,                                            
DayLogin datetime,                                            
LunchLogin datetime,                                            
LunchLogout datetime,                                            
DayLogout datetime,                                                  
DayMins int,                             
LunchMins int,                                        
BreakMins int,        
BreakLogin DATETIME,        
BreakLogout DATETIME,        
DayBreakID INT)        
                            
                            
INSERT INTO #tDetails                                    
select                                
T.ID,                              
S.TimesheetID,                              
T.DateField AS LogDate,                              
S.DayLogin,                              
S.LunchLogin,                              
S.LunchLogout,                              
S.DayLogout,                              
S.DayMins,                              
S.LunchMins,                              
S.BreakMins ,        
S.BreakLogin,        
S.BreakLogout,        
S.DayBreakID        
from @Days T left join (                              
SELECT                               
T.TimesheetID,                                             
T.LogDate,                                            
T.DayLogin,                                            
T.LunchLogin,                                            
T.LunchLogout,                                            
T.DayLogout,                                                  
T.DayMins,                                        
T.LunchMins,                                        
T.BreakMins,        
D.BreakLogin,        
D.BreakLogout,        
D.DayBreakID        
FROM AMS_TimeSheet T LEFT JOIN AMS_DayBreak D ON T.TimesheetID = D.TimesheetID        
AND D.BreakLogin IS NOT NULL AND D.BreakLogout IS NULL where T.EmployeeID = @EmployeeID  
) S on CONVERT(date,T.DateField) = CONVERT(date,S.LogDate)                          
              
insert into #THours(HoursDesc,TotalHours,LoggedHours)                              
SELECT                         
'Today Hours',                      
case when H.HolidayID is not null then 0                        
when (DATEPART(dw, LogDate) = 7 OR DATEPART(dw, LogDate) = 1)  then 0                        
else 480 end as Totalhours,                        
        
ISNULL(DayMins,0) AS LoggedHours                        
        
FROM #tDetails T left join AMS_HoliDay H                           
on CONVERT(date,T.LogDate) = CONVERT(date,H.HolidayDate)           
where CONVERT(date,T.LogDate) = CONVERT(date,@SelectedMonth)          
            
insert into #THours(HoursDesc,TotalHours,LoggedHours)                  
SELECT                    
'Weekly Hours',                        
sum(case when H.HolidayID is not null then 0                        
when (DATEPART(dw, LogDate) = 7 OR DATEPART(dw, LogDate) = 1)  then 0                        
else 480 end) as Totalhours,                        
SUM(ISNULL(DayMins,0)) AS LoggedHours                      
FROM #tDetails T left join AMS_HoliDay H                           
on CONVERT(date,T.LogDate) = CONVERT(date,H.HolidayDate)                          
where DATEPART(wk, LogDate) = DATEPART(wk, @SelectedMonth)          
                     
insert into #THours(HoursDesc,TotalHours,LoggedHours)                                
SELECT                           
'Monthly Hours',                          
sum(case when H.HolidayID is not null then 0                          
when (DATEPART(dw, LogDate) = 7 OR DATEPART(dw, LogDate) = 1)  then 0                          
else 480 end) as Totalhours,                          
sum(isnull(DayMins,0)) AS LoggedHours                        
FROM #tDetails T left join AMS_HoliDay H                             
on CONVERT(date,T.LogDate) = CONVERT(date,H.HolidayDate)                            
where Month(LogDate) = Month(@SelectedMonth)                              
                          
select                          
HoursDesc,                          
dbo.AMS_GetHours(TotalHours) AS TotalHours,                          
dbo.AMS_GetHours(LoggedHours) AS LoggedHours                          
from #THours                              
                                
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_User]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_User]
as
begin

select UserInfoID,UserName,FullName,
ISNULL(EmployeeStatus,1) As EmployeeStatus 
from AMS_UserInfo

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserCredentials1]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_UserCredentials1]                                    
@UserName NVARCHAR(100),                                    
@Password NVARCHAR(100)                  
AS                                    
BEGIN                                    
                                    
DECLARE @UserID INT = 0                  
                            
SELECT @UserID = UserInfoID                                    
FROM AMS_UserInfo                                     
WHERE UserName = @UserName                                     
AND Passwordstring = @Password and ISNULL(EmployeeStatus,1) = 1
                                    
IF (@UserID > 0)                                    
BEGIN                                    
                          
SELECT                                    
U.UserInfoID,                                    
U.UserName,                                    
U.FullName,                                    
U.Passwordstring,                  
U.DesignationID,                  
U.ReportingLeadID,                  
D.DesignationName,                  
RL.FullName AS ReportingLead,          
U.RoleID,        
U.IsOTP,      
ISNULL(U.EnableAssessmnet,0) AS EnableAssessment,    
U.EMail,  
HR.EMail AS HREmail  
FROM AMS_UserInfo U               
INNER JOIN AMS_Role R on U.RoleID = r.RoleID              
INNER JOIN AMS_Designation D on U.DesignationID = D.DesignationID                  
left JOIN AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID                  
left JOIN AMS_UserInfo HR on U.HR = HR.UserInfoID  
WHERE U.UserInfoID = @UserID                                    
                                   
END                                    
ELSE                                    
SELECT 'Invalid Username or Password'                                    
                                    
END 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserDetails]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Get_UserDetails]  
@UserinfoId int  = 0  
as  
begin  
  
SELECT U.[UserInfoID]          
      ,U.[OrgID]                  
      ,U.[BranchID]                  
      ,U.[UserName]                  
      ,U.[Passwordstring]                  
      ,U.[FullName]                  
      ,U.[CNumber]                  
      ,U.[EMail]                  
      ,U.[CreatedBy]                  
 ,U.CreatedDate,
 U.RoleID,    
 U.DesignationID,          
 U.ReportingLeadID,          
 R.RoleName,    
 D.DesignationName,          
 RL.FullName AS ReportingLead          
  FROM [dbo].[AMS_UserInfo]  U          
  inner join AMS_Role R on U.RoleID = R.RoleID    
  inner join  AMS_Designation D on U.DesignationID = D.DesignationID          
  left join  AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID          
  WHERE u.UserInfoID = @UserinfoId
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserInfo]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AMS_Get_UserInfo]                            
AS                            
BEGIN                            
 SELECT U.[UserInfoID]                    
 ,U.[OrgID]                            
 ,U.[BranchID]                            
 ,U.[UserName]                            
 ,U.[Passwordstring]                            
 ,U.[FullName]                            
 ,U.[CNumber]                            
 ,U.[EMail]                            
 ,U.[CreatedBy]                            
 ,U.CreatedDate,                    
 U.RoleID,              
 U.DesignationID,                    
 U.ReportingLeadID,                    
 R.RoleName,              
 D.DesignationName,                    
 RL.FullName AS ReportingLead,          
 isnull(U.Gender,0) as Gender,          
 case when isnull(U.Gender,0) = 0 then 'Male' else 'Female' end as GenderText,          
 ISNULL(U.JoingDate,dbo.AMS_GetLocalDate(GETUTCDATE())) as JoingDate,          
 ISNULL(U.DOB,dbo.AMS_GetLocalDate(GETUTCDATE())) as  DOB,    
 U.DepatmentID,  
 ISNULL(U.EnableAssessmnet,0) as EnableAssessmnet,    
 ISNULL(U.EmployeeStatus,1) as EmployeeStatus,    
 CASE WHEN ISNULL(U.EmployeeStatus,0) = 0 THEN 'InActive' else 'Active' end as EmployeeStatustext,    
 U.DepatmentID    
 FROM [dbo].[AMS_UserInfo]  U                    
 inner join AMS_Role R on U.RoleID = R.RoleID              
 inner join  AMS_Designation D on U.DesignationID = D.DesignationID                    
 left join  AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID                    
END 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UserPorjects]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_UserPorjects]      
@AssessmentYearID INT,    
@AssessmentModeID INT,    
@UserInfoID int    
as      
begin      
      
SELECT PU.ProjectUserMapID,      
PU.ProjectID,      
PU.UserInfoID,      
PU.Selfcomments,      
PU.ManagementComments,      
P.ProjectName,  
PL.FullName AS ProjectLead  
FROM  AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID      
inner join AMS_UserInfo PL on PU.ProjectLeadID = PL.UserInfoID  
WHERE PU.UserInfoID = @UserInfoID 
and AssessmentYearID = @AssessmentYearID 
and AssessmentModeID = @AssessmentModeID
      
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_UsersforReport]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_UsersforReport]  
@EmployeeID int,  
@IsActive bit = 0,
@RoleID int = 0
as  
begin  

if (@RoleID = 1 OR @RoleID = 7)
begin

select UserInfoID,UserName,FullName from AMS_UserInfo

end
else
begin
declare @dt AMS_Ints

insert into @dt
select distinct EmployeeID from AMS_EmployeeTask E  
where TaskID =5 and   
exists (select P.ProjectID from AMS_Projects P  
where P.ProjectLeadID = @EmployeeID  and ISNULL(IsActive,0) = @IsActive   
and P.ProjectID = E.SubTaskID)

INSERT INTO @dt
SELECT UserInfoID FROM AMS_UserInfo  WHERE ReportingLeadID = @EmployeeID


select A.ID as UserInfoID,U.UserName,U.FullName from (SELECT DISTINCT id FROM @dt) A
left join AMS_UserInfo U on A.ID = U.UserInfoID  
end

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_WorkplaceRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_WorkplaceRatings]
@EmployeeID int,
@AssessmentYearID int,
@AssessmentModeID int
as
begin

if exists(select 1 from AMS_WorkPlaceRatingsMap
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and EmployeeID = @EmployeeID)
begin

select WPM.WorkPlaceRatingsID,WP.RatingsDescription,
WPM.Rating from AMS_WorkPlaceRatingsMap WPM
inner join AMS_WorkPlaceRatings WP
on wpm.WorkPlaceRatingsID = wP.WorkPlaceRatingsID
where WPM.AssessmentYearID = @AssessmentYearID and WPM.AssessmentModeID = @AssessmentModeID
and WPM.EmployeeID = @EmployeeID

end
else
begin

select WorkPlaceRatingsID,RatingsDescription,
null as Rating from AMS_WorkPlaceRatings

end

select  
Improvements,Appreciations,AditionalContributions,AdtionalRole
from AMS_WorkPlaceRatingsComments 
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and EmployeeID = @EmployeeID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Get_WorkType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Get_WorkType]  
as  
begin  
  
select WorkTypeID,  
WorkTypedescription,  
SubTaskID from AMS_WorkType  
order by WorkTypedescription

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_BreakLogin]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_BreakLogin]
@EmployeeID int = 0,
@TimeSheetID int = 0
AS                    
Begin                    
                    
declare @DayBreakID INT = 0                    
if(@TimeSheetID <= 0)
begin
select @TimeSheetID = TimesheetID from AMS_TimeSheet                     
where EmployeeID = @EmployeeID                     
and CONVERT(date,LogDate) = CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))  
end
          
declare @Count int = 0          
select @Count = COUNT(*) from AMS_DayBreak where TimesheetID = @TimeSheetID          
          
if(@Count >= 2)          
begin          
select 'Already availed two breaks today!!'          
return;        
end          
                    
insert into AMS_DayBreak(BreakLogin,TimesheetID,EmployeeID)                    
values (dbo.AMS_GetLocalDate(GETUTCDATE()),@TimeSheetID,@EmployeeID)

UPDATE AMS_TimeSheet SET DayMins = 
DATEDIFF(MINUTE,DayLogin,dbo.AMS_GetLocalDate(GETUTCDATE())) - ISNULL(LunchMins,0) - ISNULL(BreakMins,0)
WHERE TimesheetID = @TimeSheetID
            
select SCOPE_IDENTITY()            
SELECT @TimeSheetID                    
exec AMS_Get_DayBreaks @EmployeeID                  
                  
end    
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_BreakLogout]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_BreakLogout]                
@EmployeeID inT = 0,
@TimeSheetID INT = 0
AS                
Begin                
                
declare @DayBreakID INT = 0,@BreakMins int  
IF(@TimeSheetID <= 0)
BEGIN
select @TimeSheetID = TimesheetID from AMS_TimeSheet                 
where EmployeeID = @EmployeeID                 
and CONVERT(date,LogDate) = CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))  
END
                
select @DayBreakID = DayBreakID from AMS_DayBreak where TimesheetID = @TimeSheetID and BreakLogout is null                 
                
update AMS_DayBreak set BreakLogout = dbo.AMS_GetLocalDate(GETUTCDATE()),              
BreakMins = DATEDIFF(Minute,BreakLogin,dbo.AMS_GetLocalDate(GETUTCDATE())) where DayBreakID = @DayBreakID              
  
select @BreakMins = SUM(ISNULL(BreakMins,0)) from AMS_DayBreak where TimesheetID = @TimeSheetID  
  
update AMS_TimeSheet set BreakMins = @BreakMins where TimesheetID = @TimeSheetID  
        
select @DayBreakID        
        
SELECT @TimeSheetID                
exec AMS_Get_DayBreaks @EmployeeID              
            
end   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_CompLeave]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_CompLeave]                      
@CompensatoryLeaveID int,              
@LeaveDate date,                      
@LeaveReason nvarchar(500),                      
@EmployeeID int,                      
@ApporvalLead nvarchar(100),                  
@LeaveDurationID int = 6                  
as                      
begin                      
    
    
    
if(@CompensatoryLeaveID <= 0)      
begin      
 if(@LeaveDurationID <> 6)    
 begin    
  if exists(SELECT 1 FROM AMS_CompensatoryLeave WHERE EmployeeID = @EmployeeID AND LeaveDurationID = @LeaveDurationID    
  AND LeaveDate = @LeaveDate AND LeaveStatus NOT IN (2,6))      
  begin      
   select 'Compensatory off already applied on selected date'                    
   return;      
  end      
 end    
 else    
 begin    
  if exists(SELECT 1 FROM AMS_CompensatoryLeave WHERE EmployeeID = @EmployeeID    
  AND LeaveDate = @LeaveDate AND LeaveStatus NOT IN (2,6))      
  begin      
   select 'Compensatory off already applied on selected date'                    
   return;      
  end      
 end    
end      
else      
begin      
    
if(@LeaveDurationID <> 6)    
begin    
if exists(SELECT 1 FROM AMS_CompensatoryLeave WHERE CompensatoryLeaveID <> @CompensatoryLeaveID and      
EmployeeID = @EmployeeID AND LeaveDurationID = @LeaveDurationID      
AND LeaveDate = @LeaveDate AND LeaveStatus NOT IN (2,6))      
begin      
select 'Compensatory off already applied on selected date'                    
return;      
end      
end    
else    
begin    
if exists(SELECT 1 FROM AMS_CompensatoryLeave WHERE CompensatoryLeaveID <> @CompensatoryLeaveID and      
EmployeeID = @EmployeeID AND LeaveDate = @LeaveDate AND LeaveStatus NOT IN (2,6))      
begin      
select 'Compensatory off already applied on selected date'                    
return;      
end      
end    
end      
      
 if(DATEPART(DW, @LeaveDate) = 2                     
 OR DATEPART(DW, @LeaveDate) = 3                    
 OR DATEPART(DW, @LeaveDate) = 4                    
 OR DATEPART(DW, @LeaveDate) = 5                    
 OR DATEPART(DW, @LeaveDate) = 6)                    
 begin                    
  if not exists(select 1 from AMS_HoliDay                     
  where  CONVERT(date,HolidayDate) = CONVERT(date,@LeaveDate))                    
  begin                    
   select 'Compensatory off can be applied on Weekends or holidays'                    
   return;                    
  end                    
  else                    
  begin               
  if(@CompensatoryLeaveID <= 0)              
  begin              
   INSERT INTO AMS_CompensatoryLeave(                  
   LeaveDate,                  
   LeaveReason,                  
   EmployeeID,                  
   LeaveStatus,                  
   LeaveDurationID,leavedays,AvailedDays)                      
   VALUES(@LeaveDate,                  
   @LeaveReason,                  
   @EmployeeID,                  
   5,                  
   @LeaveDurationID,                  
   case when @LeaveDurationID = 6 then 1 else 0.5 end,          
   0)          
   set @CompensatoryLeaveID = SCOPE_IDENTITY()                      
   insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,RTRIM(LTRIM(Item)),0 from dbo.SplitString(@ApporvalLead,',')                      
  
   insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,HR,0 from AMS_UserInfo where UserInfoID = @EmployeeID  
   end              
   else              
   begin              
   update AMS_CompensatoryLeave set               
   LeaveDate = @LeaveDate,                  
   LeaveReason = @LeaveReason,                  
   LeaveStatus = 5,              
   LeaveDurationID = @LeaveDurationID,              
   leavedays = case when @LeaveDurationID = 6 then 1 else 0.5 end,          
   AvailedDays = 0        
   where CompensatoryLeaveID = @CompensatoryLeaveID              
   Delete from AMS_CompensatoryLeaveApproval where CompensatoryLeaveID = @CompensatoryLeaveID              
   
   insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,RTRIM(LTRIM(Item)),0 from dbo.SplitString(@ApporvalLead,',')                      
   
   insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,HR,0 from AMS_UserInfo where UserInfoID = @EmployeeID  
   end              
  end                    
 end                    
 else                
 begin               
 if(@CompensatoryLeaveID <= 0)              
 begin              
  INSERT INTO AMS_CompensatoryLeave(                  
  LeaveDate,                  
  LeaveReason,                  
  EmployeeID,                  
  LeaveStatus,                  
  LeaveDurationID,leavedays,AvailedDays)                      
  VALUES(@LeaveDate,                  
  @LeaveReason,                  
  @EmployeeID,                  
  5,                  
  @LeaveDurationID,                  
  case when @LeaveDurationID = 6 then 1 else 0.5 end,          
  0)                      
  set @CompensatoryLeaveID = SCOPE_IDENTITY()                      
  
  insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
  select @CompensatoryLeaveID,RTRIM(LTRIM(Item)),0 from dbo.SplitString(@ApporvalLead,',')                      

  insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,HR,0 from AMS_UserInfo where UserInfoID = @EmployeeID  

  end              
  else              
  begin              
  update AMS_CompensatoryLeave set               
   LeaveDate = @LeaveDate,                  
   LeaveReason = @LeaveReason,                  
   LeaveStatus = 5,              
   LeaveDurationID = @LeaveDurationID,              
   leavedays = case when @LeaveDurationID = 6 then 1 else 0.5 end,          
   AvailedDays = 0         
   where CompensatoryLeaveID = @CompensatoryLeaveID              
   Delete from AMS_CompensatoryLeaveApproval where CompensatoryLeaveID = @CompensatoryLeaveID              
   
   insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,RTRIM(LTRIM(Item)),0 from dbo.SplitString(@ApporvalLead,',')                      

   insert into AMS_CompensatoryLeaveApproval(CompensatoryLeaveID,LeadID,IsApproved)                      
   select @CompensatoryLeaveID,HR,0 from AMS_UserInfo where UserInfoID = @EmployeeID  
  end              
 end                
 select @CompensatoryLeaveID                      
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Component]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Component]      
@ComponentID int,        
@ProjectPhaseID int,        
@ComponentName nvarchar(500),        
@ComponentDescription nvarchar(MAX),        
@UserID int        
AS        
BEGIN        

declare @ComponentLogID int

IF(@ComponentID <= 0)        
BEGIN        
INSERT INTO AMS_Component(ComponentName,ProjectPhaseID,CreatedBy,CreatedDate,Status)        
VALUES(@ComponentName,@ProjectPhaseID,@UserID,GETDATE(),1)        
SET @ComponentID = SCOPE_IDENTITY()         
        
Insert into AMS_ComponentDescription(ComponentID,ComponentDescription)        
values(@ComponentID,@ComponentDescription)        
        
insert into AMS_ComponentLog(ComponentID,LogCreatedBy,LogCreatedDate,LogType)        
values(@ComponentID,@UserID,GETDATE(),16)        
set @ComponentLogID = SCOPE_IDENTITY()

insert into AMS_ComponentLogDescription(ComponentLogID,ComponentDescription)
values(@ComponentLogID,@ComponentDescription)
        
END        
else        
begin        
        
update AMS_Component set ComponentName = @ComponentName,      
LastUpdatedBy = @UserID,LastUpdatedDate = GETDATE()      
where ComponentID = @ComponentID        
        
update AMS_ComponentDescription set ComponentDescription = @ComponentDescription        
where ComponentID = @ComponentID        
        
insert into AMS_ComponentLog(ComponentID,LogCreatedBy,LogCreatedDate,LogType)        
values(@ComponentID,@UserID,GETDATE(),17)        
set @ComponentLogID = SCOPE_IDENTITY()

insert into AMS_ComponentLogDescription(ComponentLogID,ComponentDescription)
values(@ComponentLogID,@ComponentDescription)

end        
        
select @ComponentID        
exec AMS_Get_Component  @ProjectPhaseID      
        
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_DayLogin]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_DayLogin]                          
@EmployeeID int                          
AS                          
Begin                          
            
DECLARE @CurrentDate datetime = dbo.AMS_GetLocalDate(GETUTCDATE())          
DECLARE @DayID INT = 
cast(YEAR(@CurrentDate) AS varchar(4)) +
RIGHT('0' + cast(DAY(@CurrentDate) AS varchar(2)),2)   
+ RIGHT('0' + cast(MONTH(@CurrentDate) AS varchar(2)),2)
            
declare @TimeSheetID INT = 0                          
if not exists(select 1 from AMS_TimeSheet                     
where EmployeeID = @EmployeeID and DayID = @DayID         
and DayLogin is not null)        
begin            
 insert into AMS_TimeSheet(DayLogin,EmployeeID,LogDate,DayID)          
 values (@CurrentDate,@EmployeeID,@CurrentDate,@DayID)        
 SET @TimeSheetID = SCOPE_IDENTITY()                          
End                    
else                    
begin                    
 select @TimeSheetID = TimesheetID from AMS_TimeSheet                    
 where EmployeeID = @EmployeeID                     
 and DayID = @DayID and DayLogin is not null                    
end                    
SELECT @TimeSheetID                   
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_DayLogOut]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_DayLogOut]            
@EmployeeID int,          
@dtEmployeeTask AMS_dtEmployeeTask readonly,  
@Logouttime datetime,
@TimeSheetID INT = 0
AS                
Begin                
                
declare @BreakMins int             
IF(@TimeSheetID <= 0)
BEGIN
select @TimeSheetID = TimesheetID from AMS_TimeSheet                 
where EmployeeID = @EmployeeID                 
and CONVERT(date,LogDate) = CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))                
END
            
select @BreakMins = Sum(BreakMins) from AMS_DayBreak where TimesheetID = @TimeSheetID            
                
update AMS_TimeSheet set DayLogout = @Logouttime,  
DayMins = DATEDIFF(Minute,DayLogin,@Logouttime) - ISNULL(LunchMins,0) - ISNULL(@BreakMins ,0)        
where TimesheetID = @TimeSheetID                
          
insert into AMS_EmployeeTask(          
EmployeeID,          
TaskID,          
SubTaskID,          
WorkTypeID,          
TaskHours,          
TaskDescription,          
TimesheetID          
) select           
@EmployeeID,          
TaskID,          
SubTaskID,          
WorktypeID,          
TaskHours,          
TaskDescription,          
@TimeSheetID          
from @dtEmployeeTask          
              
SELECT @TimeSheetID               
                
end   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_DevBuild]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_DevBuild]    
@DevBuildID int,    
@ProjectPhaseID int,    
@ProjectID int,    
@BuildVersion nvarchar(50),    
@BuildPath nvarchar(500),    
@ImpactAnalysis nvarchar(2000),    
@ImpactModules nvarchar(2000),    
@BuildChanges nvarchar(2000),    
@UserID int    
as    
begin    
  
DECLARE @DevBuildLogID int    
if(@DevBuildID <= 0)    
begin    
    
INSERT INTO AMS_DevBuild(ProjectPhaseID,ProjectID,BuildVersion,BuildPath,    
ImpactAnalysis,ImpactModules,BuildChanges,BuildStatus,CreatedBy,CreatedDate)    
VALUES(@ProjectPhaseID,@ProjectID,@BuildVersion,@BuildPath,    
@ImpactAnalysis,@ImpactModules,@BuildChanges,1,@UserID,GETDATE())    
set @DevBuildID = SCOPE_IDENTITY()    
  
INSERT INTO AMS_DevBuildLog(DevBuildID,LogCreatedBy,LogCreatedDate,LogType)  
VALUES(@DevBuildID,@UserID,GETDATE(),16)  
  
set @DevBuildLogID =  SCOPE_IDENTITY()  
  
insert into AMS_DevlogDescription(DevBuildLogID,BuildVersion,BuildPath,  
BuildChanges,ImpactAnalysis,ImpactModules,BuildStatus)  
values(@DevBuildLogID,@BuildVersion,@BuildPath,@BuildChanges,  
@ImpactAnalysis,@ImpactModules,1)  
  
end    
else    
begin    
    
update AMS_DevBuild set BuildVersion = @BuildVersion,BuildPath = @BuildPath,    
ImpactAnalysis=@ImpactAnalysis,ImpactModules = @ImpactModules,BuildChanges = @BuildChanges,    
LastupdatedBy = @UserID,LastUpdatedDate = GETDATE()     
where DevBuildID = @DevBuildID    
  
INSERT INTO AMS_DevBuildLog(DevBuildID,LogCreatedBy,LogCreatedDate,LogType)  
VALUES(@DevBuildID,@UserID,GETDATE(),17)  
  
set @DevBuildLogID =  SCOPE_IDENTITY()  
  
insert into AMS_DevlogDescription(DevBuildLogID,BuildVersion,BuildPath,  
BuildChanges,ImpactAnalysis,ImpactModules,BuildStatus)  
values(@DevBuildLogID,@BuildVersion,@BuildPath,@BuildChanges,  
@ImpactAnalysis,@ImpactModules,1)  
  
end    
select @DevBuildID    
exec AMS_Get_DevBuild @ProjectPhaseID    
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_EmployeeTask]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_EmployeeTask]    
@EmployeeID INT,
@TimesheetID INT,
@dtEmployeeTask AMS_dtEmployeeTask readonly
AS    
BEGIN    

delete from AMS_EmployeeTask where TimesheetID = @TimesheetID

insert into AMS_EmployeeTask(            
EmployeeID,            
TaskID,            
SubTaskID,            
WorkTypeID,            
TaskHours,            
TaskDescription,            
TimesheetID            
) select             
@EmployeeID,            
TaskID,            
SubTaskID,            
WorktypeID,            
TaskHours,            
TaskDescription,            
@TimeSheetID            
from @dtEmployeeTask
    
SELECT @TimesheetID
    
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_FYear]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_FYear]    
@FYearID int,      
@Fromdate date,      
@ToDate date,  
@EnableAssessment Bit = 0  
as      
begin      
      
IF(@FYearID<=0)      
BEGIN      
INSERT INTO AMS_FYear(FromDate,ToDate,FYearName,EnableAssessment)      
VALUES(@Fromdate,@ToDate, cast(YEAR(@Fromdate) as varchar(10)) + '-' + CAST(YEAR(@ToDate) as varchar(10)),@EnableAssessment)      
END      
ELSE      
BEGIN      
update AMS_FYear set FromDate = @Fromdate,      
ToDate = @ToDate,      
FYearName = cast(YEAR(@Fromdate) as varchar(10)) + '-' + CAST(YEAR(@ToDate) as varchar(10)),  
EnableAssessment = @EnableAssessment  
where FYearID = @FYearID      
END    
    
select @FYearID    
    
exec AMS_Get_FYear    
    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_GeneralRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_GeneralRatings]            
@UserInfoID INT,            
@AssessmentYearID INT,            
@dtRatings AMS_dtPorjectRatings readonly,          
@RatingUserID int = 0,
@AssessmentModeID INT
As            
Begin            
            
IF NOT EXISTS (SELECT 1 FROM AMS_GenaralRatings             
WHERE AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
AND UserInfoID = @RatingUserID and RatingUserID = @UserInfoID)            
BEGIN            
            
INSERT INTO AMS_GenaralRatings(            
AssessmentYearID,            
UserInfoID,            
GeneralPerformanceID,            
Rating,          
RatingUserID,
AssessmentModeID)            
SELECT @AssessmentYearID,            
@RatingUserID,            
CriteriaID,            
Rating ,          
@UserInfoID,
@AssessmentModeID
FROM @dtRatings            
            
END            
ELSE            
BEGIN            
            
UPDATE GR SET             
GR.Rating = R.Rating            
from AMS_GenaralRatings GR inner join @dtRatings R             
on GR.GeneralPerformanceID = R.CriteriaID            
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and UserInfoID = @RatingUserID   and RatingUserID = @UserInfoID          
            
END            
            
End  
GO
/****** Object:  StoredProcedure [dbo].[AMS_INS_Holiday]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_INS_Holiday]              
@HolidayID int = 0,              
@HolidayDate date,              
@HolidayName nvarchar(500),              
@CategoryID int,              
@UserID int              
as              
begin              
    
DECLARE @DayID int = cast(YEAR(@HolidayDate) AS varchar(4)) + 
RIGHT('0' + cast(DAY(@HolidayDate) AS varchar(2)),2) +   
RIGHT('0' + cast(MONTH(@HolidayDate) AS varchar(2)),2)
              
IF(@HolidayID <= 0)              
BEGIN              
              
insert into AMS_HoliDay(HolidayDate,HolidayName,CategoryID,CreatedBy,CreatedDate,DayID)      
values(@HolidayDate,@HolidayName,@CategoryID,@UserID,dbo.AMS_GetLocalDate(GETUTCDate()) ,@DayID)        
set @HolidayID = SCOPE_IDENTITY()              
              
END              
              
else              
begin              
              
update AMS_HoliDay set HolidayDate = @HolidayDate,              
HolidayName = @HolidayName,              
CategoryID = @CategoryID,              
UpdatedBy = @UserID,              
UpdatedDate = dbo.AMS_GetLocalDate(GETDATE()),        
DayID = @DayID    
where HolidayID = @HolidayID              
              
end              
              
select @HolidayID              
exec AMS_Get_HoliDay            
              
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_LeadRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_LeadRatings]                
@UserInfoID INT,  
@AssessmentYearID INT,  
@dtRatings AMS_dtPorjectRatings1 readonly,  
@RatingUserID int = 0 ,
@AssessmentModeID int
As                
Begin                
                
IF NOT EXISTS (SELECT 1 FROM AMS_LeadRatings  
WHERE AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
AND UserInfoID = @RatingUserID and RatingUserID = @UserInfoID)                
BEGIN                
                
INSERT INTO AMS_LeadRatings(                
AssessmentYearID,                
UserInfoID,                
LeadPerformanceID,                
Rating,              
RatingUserID,  
Comments,
AssessmentModeID)                
SELECT @AssessmentYearID,                
@RatingUserID,                
CriteriaID,                
Rating ,              
@UserInfoID,  
Comments,
@AssessmentModeID
FROM @dtRatings                
                
END                
ELSE                
BEGIN                
                
UPDATE GR SET                 
GR.Rating = R.Rating,  
GR.Comments = R.Comments  
from AMS_LeadRatings GR inner join @dtRatings R                 
on GR.LeadPerformanceID = R.CriteriaID                
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and UserInfoID = @RatingUserID   and RatingUserID = @UserInfoID              
                
END                
                
End  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Leave]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Leave]    
@EmployeeLeaveID int,    
@EmployeeID int,    
@FYearID int,    
@leaveTypeID int,    
@FromDate date,    
@ToDate date,    
@LeaveCategory int,    
@ReasonForLeave nvarchar(1000) = '',                                              
@IsDeliveryExists bit,                                              
@IsCompleted bit,                                              
@ProjectPlan nvarchar(500) = '',                                              
@EmergencyContact nvarchar(500) = '',                                              
@ApprovalLead nvarchar(100),                                      
@LeaveDuration int = 6                                      
as                                              
begin                                              
              
if(DATEPART(DW, @FromDate) = 1 OR DATEPART(DW, @FromDate) = 7                       
OR DATEPART(DW, @ToDate) = 1 OR DATEPART(DW, @ToDate) = 7)                                            
begin                       
 select 'From Date or To Date cannot be selected on weekends'                      
 return;                      
end                      
                      
if exists(select 1 from AMS_HoliDay                       
where  CONVERT(date,HolidayDate) = CONVERT(date,@FromDate))                                            
begin                       
 select 'From Date cannot be selected on holidays'                                            
 return;                                            
end                       
                      
if exists(select 1 from AMS_HoliDay                       
where  CONVERT(date,HolidayDate) = CONVERT(date,@ToDate))                                            
begin                                            
 select 'To Date cannot be selected on holidays'                      
 return;                      
end                      
                  
declare @IsEdit bit = 0                    
declare @LeaveDays decimal(10,2),@OldLeaveDays decimal(10,2)                    
if(@LeaveDuration != 6)                       
begin                                  
 set @LeaveDays = 0.5                                  
end                                  
else  if(CONVERT(date,@FromDate) = CONVERT(date,@ToDate))                                
begin                                
 set @LeaveDays = 1                                
end                                
else                                
begin                                  
 Declare @Current as date = @FromDate                                
 Create table #tmpDates(displayDate date)                                
 WHILE @Current <= @ToDate                                
  BEGIN                                
   insert into #tmpDates                                
   VALUES(@Current);                                
   set @Current = DATEADD(DD, 1, @Current)                                
  END                                
if(@leaveTypeID = 5 OR @leaveTypeID = 6)          
begin          
select @LeaveDays = COUNT(*) from #tmpDates          
end          
else          
begin          
 select @LeaveDays = SUM(ld) from (Select CAse when  DATEPART(DW,displayDate) = 1 then 0                                
 when DATEPART(DW,displayDate) = 7 then 0                                
 when ISNULL(H.HolidayID,0) > 0 then 0                                
 else 1 end as ld                                
 from #tmpDates T left join AMS_HoliDay H                                
 ON CONVERT(date,T.displayDate) = CONVERT(date,H.HolidayDate)) AS A          
end          
          
end                      
              
IF(@leaveTypeID = 1 OR @leaveTypeID = 2 OR @leaveTypeID = 3 OR @leaveTypeID = 4)                  
BEGIN                  
                  
DECLARE @LeaveBalance decimal(10,2) = 0                  
select @LeaveBalance = LeaveBalance                   
from dbo.AMS_GetLeaveDetailsByType(@leaveTypeID,@FYearID,@EmployeeID)                  
select @OldLeaveDays = LeaveDays from AMS_EmployeeLeave where EmployeeLeaveID = @EmployeeLeaveID                      
if(@LeaveDays > (@LeaveBalance + ISNULL(@OldLeaveDays,0)))                  
BEGIN            
SELECT 'Leave days cannot be greater than leave balance days'                  
RETURN;                  
END                  
                  
END                  
    
if(@EmployeeLeaveID <= 0)            
begin              
 if(@LeaveDuration <> 6)              
 begin              
  IF NOT EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
  WHERE EmployeeID = @EmployeeID  AND FYearID = @FYearID               
  AND @FromDate >= LeaveFromDate AND @FromDate <= LeaveFromDate              
  and LeaveDurationID = @LeaveDuration  AND LeaveStatusID NOT IN (2,6))    
  BEGIN              
   IF EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
   WHERE EmployeeID = @EmployeeID  AND FYearID = @FYearID               
   AND @ToDate >= LeaveFromDate AND @ToDate <= LeaveFromDate              
   AND LeaveDurationID = @LeaveDuration AND LeaveStatusID NOT IN (2,6))              
   BEGIN              
    SELECT 'Leave already applied on selected dates'                  
    RETURN;                  
   END              
  END              
  ELSE              
  BEGIN              
  SELECT 'Leave already applied on selected dates'                  
  RETURN;                  
  END              
 end              
 ELSE              
 BEGIN              
  IF NOT EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
  WHERE EmployeeID = @EmployeeID  AND FYearID = @FYearID               
  AND @FromDate >= LeaveFromDate AND @FromDate <= LeaveFromDate    
  AND LeaveStatusID NOT IN (2,6))              
  BEGIN              
   IF EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
   WHERE EmployeeID = @EmployeeID  AND FYearID = @FYearID               
   AND @ToDate >= LeaveFromDate AND @ToDate <= LeaveFromDate    
   AND LeaveStatusID NOT IN (2,6))              
   BEGIN              
    SELECT 'Leave already applied on selected dates'                  
    RETURN;                  
   END              
  END              
  ELSE              
  BEGIN              
   SELECT 'Leave already applied on selected dates'                  
   RETURN;                  
  END              
 END              
end              
ELSE              
BEGIN              
              
 if(@LeaveDuration <> 6)              
 begin              
  IF NOT EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
  WHERE EmployeeLeaveID <> @EmployeeLeaveID AND EmployeeID = @EmployeeID  AND FYearID = @FYearID               
  AND @FromDate >= LeaveFromDate AND @FromDate <= LeaveFromDate              
  and LeaveDurationID = @LeaveDuration AND LeaveStatusID NOT IN (2,6))              
  BEGIN              
   IF EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
   WHERE EmployeeLeaveID <> @EmployeeLeaveID AND EmployeeID = @EmployeeID  AND FYearID = @FYearID               
   AND @ToDate >= LeaveFromDate AND @ToDate <= LeaveFromDate              
   AND LeaveDurationID = @LeaveDuration AND LeaveStatusID NOT IN (2,6))              
   BEGIN              
    SELECT 'Leave already applied on selected dates'                  
    RETURN;                  
   END              
  END              
  ELSE              
  BEGIN              
   SELECT 'Leave already applied on selected dates'                  
   RETURN;                  
  END              
 end              
 ELSE              
 BEGIN              
  IF NOT EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
  WHERE EmployeeLeaveID <> @EmployeeLeaveID AND EmployeeID = @EmployeeID  AND FYearID = @FYearID               
  AND @FromDate >= LeaveFromDate AND @FromDate <= LeaveFromDate AND LeaveStatusID NOT IN (2,6))              
  BEGIN              
   IF EXISTS(SELECT 1 FROM AMS_EmployeeLeave               
   WHERE EmployeeLeaveID <> @EmployeeLeaveID AND EmployeeID = @EmployeeID  AND FYearID = @FYearID               
   AND @ToDate >= LeaveFromDate AND @ToDate <= LeaveFromDate AND LeaveStatusID NOT IN (2,6))              
   BEGIN              
    SELECT 'Leave already applied on selected dates'                  
    RETURN;                  
   END              
  END              
  ELSE              
  BEGIN              
   SELECT 'Leave already applied on selected dates'                  
   RETURN;                  
  END              
 END            
              
END              
                    
if(@EmployeeLeaveID <= 0)                       
begin                      
 INSERT INTO AMS_EmployeeLeave(EmployeeID,LeaveTypeID,LeaveFromDate,LeaveToDate,LeaveCategoryID,      
 FYearID,LeaveReason,IsProjectDelivery,IsCompleted,ProjectPlan,EmergencyContact,                      
 LeaveDays,LeaveStatusID,LeaveDurationID)                      
 values(@EmployeeID,@leaveTypeID,@FromDate,@ToDate,@LeaveCategory,                      
 @FYearID,@ReasonForLeave,@IsDeliveryExists,@IsCompleted,@ProjectPlan,                      
 @EmergencyContact,@LeaveDays,5,@LeaveDuration)                     
 set @EmployeeLeaveID = SCOPE_IDENTITY()                                              
 insert into AMS_LeaveApproval(EmoloyeeLeaveID,LeadID,IsApproved)                                              
 select @EmployeeLeaveID,LTRIM(RTRIM(item)),0 from dbo.SplitString(@ApprovalLead,',')                                              
 insert into AMS_LeaveApproval(EmoloyeeLeaveID,LeadID,IsApproved)                                              
 select @EmployeeLeaveID,HR,0 from AMS_UserInfo where UserInfoID = @EmployeeID        
end                            
else                            
begin              
select @OldLeaveDays = LeaveDays from AMS_EmployeeLeave where EmployeeLeaveID = @EmployeeLeaveID                    
set @IsEdit = 1                    
 update AMS_EmployeeLeave set                             
 LeaveFromDate= @FromDate,LeaveToDate = @ToDate,LeaveCategoryID = @LeaveCategory,                                              
 LeaveReason = @ReasonForLeave,IsProjectDelivery = @IsDeliveryExists,                            
 IsCompleted = @IsCompleted,ProjectPlan = @ProjectPlan,                            
 EmergencyContact = @EmergencyContact,LeaveDays = @LeaveDays,                            
 LeaveDurationID = @LeaveDuration,LeaveStatusID = 5                          
 where EmployeeLeaveID = @EmployeeLeaveID                            
 delete from  AMS_LeaveApproval where EmoloyeeLeaveID = @EmployeeLeaveID                            
    
 insert into AMS_LeaveApproval(EmoloyeeLeaveID,LeadID,IsApproved)                                              
 select @EmployeeLeaveID,LTRIM(RTRIM(item)),0 from dbo.SplitString(@ApprovalLead,',')                            
        
 insert into AMS_LeaveApproval(EmoloyeeLeaveID,LeadID,IsApproved)                                              
 select @EmployeeLeaveID,HR,0 from AMS_UserInfo where UserInfoID = @EmployeeID        
end                      
                      
IF(@leaveTypeID = 4)                        
BEGIN                     
if(@IsEdit = 0)                    
begin                    
exec AMS_Upd_CompLeavesStatus @EmployeeID,@LeaveDays,0,@FromDate               
end                    
 else                    
 begin                    
 if(@LeaveDays <> @OldLeaveDays)                    
 begin                    
exec AMS_Upd_CompLeavesStatus @EmployeeID,@OldLeaveDays,1, @FromDate
exec AMS_Upd_CompLeavesStatus @EmployeeID,@LeaveDays,0,@FromDate
end                    
end                    
end                      
select @EmployeeLeaveID                                              
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_LunchLogin]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_LunchLogin]        
@EmployeeID int = 0,
@TimeSheetID int = 0
AS        
Begin        
        
if(@TimeSheetID <= 0)
begin
select @TimeSheetID = TimesheetID from AMS_TimeSheet         
where EmployeeID = @EmployeeID         
and CONVERT(date,LogDate) = CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))  
end
        
update AMS_TimeSheet set 
LunchLogin = dbo.AMS_GetLocalDate(GETUTCDATE()),
DayMins = DATEDIFF(MINUTE,DayLogin,dbo.AMS_GetLocalDate(GETUTCDATE())) - ISNULL(BreakMins,0)
where TimesheetID = @TimeSheetID        
        
SELECT @TimeSheetID        
      
end    
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_LunchLogout]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_LunchLogout]                        
@EmployeeID int = 0,
@TimeSheetID INT = 0
AS                          
Begin                          

IF(@TimeSheetID <= 0)
BEGIN
select @TimeSheetID = TimesheetID from AMS_TimeSheet                           
where EmployeeID = @EmployeeID                           
and CONVERT(date,LogDate) = CONVERT(date,dbo.AMS_GetLocalDate(GETUTCDATE()))  
END
                    
declare @LunchMins int = 0                    
select @LunchMins = DATEDIFF(MINUTE,LunchLogin,dbo.AMS_GetLocalDate(GETUTCDATE())) from AMS_TimeSheet where TimesheetID = @TimeSheetID                                             
if( @LunchMins <= 15)                    
begin    
SELECT 'Please wait for some time..'                    
return;    
end    
                    
if(@LunchMins < 30)      
set @LunchMins = 30  
      
update AMS_TimeSheet set LunchLogout = dbo.AMS_GetLocalDate(GETUTCDATE()),  
LunchMins = @LunchMins  
where TimesheetID = @TimeSheetID                          
                        
SELECT @TimeSheetID                                     
                      
end   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_MGoals]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_MGoals]
@EmployeeID int,
@AssessmentYearID int,
@AssessmentModeID int,
@MGoalsAssessment nvarchar(max),
@MGoalForYear nvarchar(1000),
@MGoalforHalfYear nvarchar(1000),
@MGoalForHalfYearDetails nvarchar(max)
as
begin

if not exists(SELECT 1 FROM AMS_WorkPlaceRatingsComments WHERE 
AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID
AND EmployeeID = @EmployeeID)
BEGIN

INSERT INTO AMS_WorkPlaceRatingsComments(EmployeeID,
AssessmentYearID,AssessmentModeID,MGoalsAssessment,
MGoalForYear,MGoalforHalfYear,MGoalForHalfYearDetails)
VALUES(@EmployeeID,
@AssessmentYearID,@AssessmentModeID,@MGoalsAssessment,
@MGoalForYear,@MGoalforHalfYear,@MGoalForHalfYearDetails)

END
ELSE
BEGIN

UPDATE AMS_WorkPlaceRatingsComments
SET MGoalsAssessment = @MGoalsAssessment,
MGoalForYear = @MGoalForYear,
MGoalforHalfYear = @MGoalforHalfYear ,
MGoalForHalfYearDetails = @MGoalForHalfYearDetails
WHERE AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID
AND EmployeeID = @EmployeeID


END


end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Project]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Project]            
@ProjectID int = 0,            
@ProjectName nvarchar(500),          
@ProjectLeadID int,    
@IsActive bit    
as            
begin            
            
if(@ProjectID > 0)            
begin            
update AMS_Projects           
set ProjectName = @ProjectName,          
ProjectLeadID = @ProjectLeadID,    
IsActive = @IsActive    
where ProjectID = @ProjectID            
end            
else            
begin            
insert into AMS_Projects(ProjectName,ProjectLeadID,IsActive)            
values(@ProjectName,@ProjectLeadID,@IsActive)                      
SET @ProjectID = SCOPE_IDENTITY()
end            
select @ProjectID      
exec AMS_Get_Project      
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectEmployee]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_ProjectEmployee]        
@ProjectEmployeeID int,        
@ProjectPhaseID int,      
@EmployeeID int,        
@IsActive bit,  
@UserID int  
as        
begin        
        
if(@ProjectEmployeeID<= 0)        
begin        

if exists(select 1 from AMS_ProjectEmployee where EmployeeID = @EmployeeID and ProjectPhaseID = @ProjectPhaseID)
begin
select 'Selected Employee Already Exists!'
return;
end

insert into AMS_ProjectEmployee(ProjectPhaseID,EmployeeID,JoiningDate,IsActive,CreatedBy)  
values(@ProjectPhaseID,@EmployeeID,GETDATE(),@IsActive,@UserID)  
set @ProjectEmployeeID = SCOPE_IDENTITY()  
end  
else  
begin  
  
update AMS_ProjectEmployee      
set IsActive = @IsActive    
where ProjectEmployeeID = @ProjectEmployeeID        
        
end        
select @ProjectEmployeeID        
exec AMS_Get_ProjectEmployee @ProjectPhaseID    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectPhase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_ProjectPhase]      
@ProjectPhaseID int,      
@ProjectID int,      
@PhaseName nvarchar(500),      
@UserID int,    
@IsActive bit    
as      
begin      
      
if(@ProjectPhaseID > 0)      
begin      
update AMS_ProjectPhase set PhaseName = @PhaseName,      
UpdatedBy = @UserID,UpdatedDate = GETDATE(),    
 IsActive =@IsActive    
where ProjectPhaseID = @ProjectPhaseID      
end      
else      
begin      

if exists(select 1 from AMS_ProjectPhase where ProjectID = @ProjectID and PhaseName = @PhaseName)
begin
select 'Phase already exists'
return;
end

insert into AMS_ProjectPhase(ProjectID,PhaseName,CreatedBy,CreatedDate,IsActive)      
values(@ProjectID,@PhaseName,@UserID,GETDATE(),@IsActive)      
set @ProjectPhaseID = SCOPE_IDENTITY()      
end      
select @ProjectPhaseID      
EXEC AMS_Get_ProjectPhase @ProjectID  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_ProjectRatings]              
@ProjectUserMapID int = -1,              
@ProjectID INT,              
@AssessmentYear int,              
@SelfComments nvarchar(max),              
@ManagementComments nvarchar(max),              
@dtRatings AMS_dtPorjectRatings1 readonly,              
@UserInfoID int,        
@LeadID int,
@AssessmentModeID INT
as              
begin              
              
if(@ProjectUserMapID <= 0)              
begin              
INSERT INTO AMS_ProjectUserMap(        
ProjectID,        
UserInfoID,        
Selfcomments,        
ManagementComments,        
AssessmentYearID,        
ProjectLeadID,
AssessmentModeID)              
VALUES(@ProjectID,        
@UserInfoID,        
@SelfComments,        
@ManagementComments,        
@AssessmentYear,        
@LeadID,
@AssessmentModeID)              
              
set @ProjectUserMapID = SCOPE_IDENTITY()              
              
insert into AMS_ProjectCriteriaMap(CriteriaID,ProjectUserMapID,UserInfoID,RatingPercentage,Rating,Comments)              
select CriteriaID,@ProjectUserMapID,@UserInfoID,0,Rating,Comments from @dtRatings              
              
end          
else          
begin          
  
DECLARE @OldLEadID int = 0  
select @OldLEadID = ProjectLeadID from AMS_ProjectUserMap where ProjectUserMapID = @ProjectUserMapID  
  
if(@LeadID <> @OldLEadID)  
begin  
  
delete from AMS_ProjectCriteriaMap where ProjectUserMapID = @ProjectUserMapID   
and UserInfoID = @OldLEadID  
  
end  
          
update AMS_ProjectUserMap          
set ProjectID = @ProjectID,          
Selfcomments = @SelfComments,          
ManagementComments = @ManagementComments,        
ProjectLeadID = @LeadID
where ProjectUserMapID = @ProjectUserMapID          
          
delete from AMS_ProjectCriteriaMap where ProjectUserMapID = @ProjectUserMapID and          
UserInfoID = @UserInfoID          
          
insert into AMS_ProjectCriteriaMap(CriteriaID,ProjectUserMapID,UserInfoID,RatingPercentage,Rating,Comments)
select CriteriaID,@ProjectUserMapID,@UserInfoID,0,Rating,Comments from @dtRatings          
          
end              
              
select @ProjectUserMapID              
              
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_ProjectWorkType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_ProjectWorkType]  
@ProjectWorkTypeID int = 0,    
@WorkTypeDescription nvarchar(100)    
as    
begin    
    
if(@ProjectWorkTypeID = 0)    
begin    
insert into AMS_ProjectWorkType(WorkTypeDescription)    
values(@WorkTypeDescription)    
set @ProjectWorkTypeID= SCOPE_IDENTITY()    
end    
else    
begin    
    
update AMS_ProjectWorkType     
set WorkTypeDescription = @WorkTypeDescription     
where ProjectWorkTypeID = @ProjectWorkTypeID    
    
end    
    
select @ProjectWorkTypeID     
exec AMS_Get_ProjectWorkType    
    
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Requirement]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Requirement]    
@ComponentID int,    
@RequirementID int,    
@RequirementName nvarchar(500),    
@RDescription nvarchar(1000),    
@Description nvarchar(max),    
@UserID int,    
@ProjectPhaseID int    
AS            
BEGIN            
  
declare @RequirementLogID int  
  
IF(@RequirementID <= 0)            
BEGIN            
INSERT INTO AMS_Requirement(ComponentID,RequirementName,RDescription,CreatedBy,CreatedDate)    
VALUES(@ComponentID,@RequirementName,@RDescription,@UserID,GETDATE())    
SET @RequirementID = SCOPE_IDENTITY()             
            
Insert into AMS_RequirementDescription(RequirementID,Description)            
values(@RequirementID,@Description)    
            
insert into AMS_RequirementLog(RequirementID,LogCreatedBy,LogCreatedDate,LogType)            
values(@RequirementID,@UserID,GETDATE(),16)            
set @RequirementLogID = SCOPE_IDENTITY()  
insert into AMS_RequirementLogDescription(RequirementLogID,RequirementDescription)  
values(@RequirementLogID,@Description)  
            
END            
else            
begin            
            
update AMS_Requirement set RequirementName = @RequirementName,    
RDescription = @RDescription,    
LastUpdatedBy = @UserID,LastUpdatedDate = GETDATE()          
where RequirementID = @RequirementID    
            
update AMS_RequirementDescription set Description = @Description    
where RequirementID = @RequirementID    
            
insert into AMS_RequirementLog(RequirementID,LogCreatedBy,LogCreatedDate,LogType)            
values(@RequirementID,@UserID,GETDATE(),17)    
set @RequirementLogID = SCOPE_IDENTITY()  
insert into AMS_RequirementLogDescription(RequirementLogID,RequirementDescription)  
values(@RequirementLogID,@Description)  
    
end            
            
select @RequirementID            
exec AMS_Get_Requirement  @ProjectPhaseID          
            
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Scenario]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Scenario]      
@RequirementID int,        
@ScenarioID int,        
@Shortdescription nvarchar(500),        
@LongDescription nvarchar(max),        
@UserID int,        
@ProjectPhaseID int      
AS                
BEGIN                

declare @ScenarioLogID int
IF(@ScenarioID <= 0)                
BEGIN                
INSERT INTO AMS_Scenario(RequirementID,ShortDescription,CreatedBy,CreatedDate)      
VALUES(@RequirementID,@Shortdescription,@UserID,GETDATE())        
SET @ScenarioID = SCOPE_IDENTITY()                 
                
Insert into AMS_ScenarioDescription(ScenarioID,ScenarioDescription)                
values(@ScenarioID,@LongDescription)        
                
insert into AMS_ScenarioLog(ScenarioID,LogCreatedBy,LogCreatedDate,LogType)      
values(@ScenarioID,@UserID,GETDATE(),16)      
set @ScenarioLogID = SCOPE_IDENTITY()
insert into AMS_ScenarioLogDescription(ScenarioLogID,ScenarioDescription)
values(@ScenarioLogID,@LongDescription)
                
END                
else                
begin                
                
update AMS_Scenario set ShortDescription = @Shortdescription,      
LastUpdatedBy = @UserID,      
LastUpdatedDate = GETDATE()              
where ScenarioID = @ScenarioID      
                
update AMS_ScenarioDescription set ScenarioDescription = @LongDescription      
where ScenarioID = @ScenarioID      
                
insert into AMS_ScenarioLog(ScenarioID,LogCreatedBy,LogCreatedDate,LogType)      
values(@ScenarioID,@UserID,GETDATE(),17)      
set @ScenarioLogID = SCOPE_IDENTITY()
insert into AMS_ScenarioLogDescription(ScenarioLogID,ScenarioDescription)
values(@ScenarioLogID,@LongDescription)        
end                
                
select @ScenarioID      
exec AMS_Get_Scenario @ProjectPhaseID              
                
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_SelectedTestcases]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_SelectedTestcases]    
@DevBuildID int,    
@dtTestcases AMS_Ints readonly,
@UserID int
as    
begin    

DECLARE @DevBuildLogID int        

INSERT INTO AMS_TestExecution(DevBuildID,TestcaseID)    
select @DevBuildID,ID from @dtTestcases D    
where not exists (select TestcaseID from AMS_TestExecution TE     
where D.ID = TE.TestcaseID and TE.DevBuildID = @DevBuildID)    
  
update AMS_DevBuild set BuildStatus = 2 where DevBuildID = @DevBuildID    

INSERT INTO AMS_DevBuildLog(DevBuildID,LogCreatedBy,LogCreatedDate,LogType)  
VALUES(@DevBuildID,@UserID,GETDATE(),17)  
  
set @DevBuildLogID =  SCOPE_IDENTITY()  
  
insert into AMS_DevlogDescription(DevBuildLogID,BuildVersion,BuildPath,  
BuildChanges,ImpactAnalysis,ImpactModules,BuildStatus)  
select @DevBuildLogID,BuildVersion,BuildPath,BuildChanges,  
ImpactAnalysis,ImpactModules,2 from AMS_DevBuild where DevBuildID = @DevBuildID

select @DevBuildID    
    
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_SelfGoals]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_SelfGoals]
@EmployeeID int,
@AssessmentYearID int,
@AssessmentModeID int,
@AchivedGoals nvarchar(max),
@SelfGoalForYear nvarchar(1000),
@SelfGoalforHalfYear nvarchar(1000),
@SelfGoalForHalfYearDetails nvarchar(max)
as
begin

if not exists(SELECT 1 FROM AMS_WorkPlaceRatingsComments WHERE 
AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID
AND EmployeeID = @EmployeeID)
BEGIN

INSERT INTO AMS_WorkPlaceRatingsComments(EmployeeID,
AssessmentYearID,AssessmentModeID,AchivedGoals,
SelfGoalForYear,SelfGoalforHalfYear,SelfGoalForHalfYearDetails)
VALUES(@EmployeeID,
@AssessmentYearID,@AssessmentModeID,@AchivedGoals,
@SelfGoalForYear,@SelfGoalforHalfYear,@SelfGoalForHalfYearDetails)

END
ELSE
BEGIN

UPDATE AMS_WorkPlaceRatingsComments
SET AchivedGoals = @AchivedGoals,
SelfGoalForYear = @SelfGoalForYear,
SelfGoalforHalfYear = @SelfGoalforHalfYear ,
SelfGoalForHalfYearDetails = @SelfGoalForHalfYearDetails
WHERE AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID
AND EmployeeID = @EmployeeID


END


end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_SubTask]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_SubTask]  
@SubTaskID int = 0,  
@SubTaskDecription nvarchar(100),  
@TaskID int  
as  
begin  
  
if(@SubTaskID = 0)  
begin  
insert into AMS_SubTask(SubTaskDescription,TaskID)  
values(@SubTaskDecription,@TaskID)  
set @SubTaskID = SCOPE_IDENTITY()  
end  
else  
begin  
  
update AMS_SubTask set SubTaskDescription = @SubTaskDecription,  
TaskID = @TaskID where SubTaskID = @SubTaskID  
  
end  
  
select @SubTaskID  
exec AMS_Get_SubTask  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Task]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Task]  
@TaskID int = 0,  
@TaskDescription nvarchar(100)  
as  
begin  
  
if(@TaskID = 0)  
begin  
insert into AMS_Task(TaskDescription)  
values(@TaskDescription)  
set @TaskID= SCOPE_IDENTITY()  
end  
else  
begin  
  
update AMS_Task   
set TaskDescription = @TaskDescription   
where TaskID = @TaskID  
  
end  
  
select @TaskID   
exec AMS_Get_Task  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_TechnicalRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_TechnicalRatings]              
@UserInfoID INT,              
@AssessmentYearID INT,              
@dtRatings AMS_dtPorjectRatings readonly,            
@RatingUserID int = 0,
@AssessmentModeID int
As              
Begin              
              
IF NOT EXISTS (SELECT 1 FROM AMS_TechnicalRatings      
WHERE AssessmentYearID = @AssessmentYearID and AssessmentModeID  = @AssessmentModeID
AND UserInfoID = @RatingUserID and RatingUserID = @UserInfoID)              
BEGIN              
              
INSERT INTO AMS_TechnicalRatings(              
AssessmentYearID,              
UserInfoID,              
TechnicalPerformanceID,              
Rating,            
RatingUserID,
AssessmentModeID)              
SELECT @AssessmentYearID,              
@RatingUserID,              
CriteriaID,              
Rating ,            
@UserInfoID,
@AssessmentModeID
FROM @dtRatings              
              
END              
ELSE              
BEGIN              
              
UPDATE GR SET               
GR.Rating = R.Rating              
from AMS_TechnicalRatings GR inner join @dtRatings R               
on GR.TechnicalPerformanceID = R.CriteriaID              
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID
and UserInfoID = @RatingUserID   and RatingUserID = @UserInfoID            
              
END              
              
End  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_Testcase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_Testcase]  
@TestcaseID int,            
@ScenarioID int,            
@TestcaseName nvarchar(500),            
@Complexity int,            
@Severity int,            
@TestcaseType int,            
@RegressionRequired bit,            
@TestSteps nvarchar(max),            
@ExpectedResult nvarchar(max),            
@UserID int,            
@ProjectPhaseID int          
AS                    
BEGIN                    
    
declare @TestCaseLogID int    
IF(@TestcaseID <= 0)                    
BEGIN                    
INSERT INTO AMS_Testcase(ScenarioID,TestcaseName,Complexity,Severity,  
TestcaseType,RegressionRequired,CreatedBy,CreatedDate,ProjectPhaseID)          
VALUES(@ScenarioID,@TestcaseName,@Complexity,@Severity,  
@TestcaseType,@RegressionRequired,@UserID,GETDATE(),@ProjectPhaseID)            
SET @TestcaseID = SCOPE_IDENTITY()                     
                    
Insert into AMS_TestcaseDescription(TestcaseID,TestSteps,ExpectedResult)  
values(@TestcaseID,@TestSteps,@ExpectedResult)  
                    
insert into AMS_TestcaseLog(TestcaseID,LogCreatedBy,LogCreatedDate,LogType)  
values(@TestcaseID,@UserID,GETDATE(),16)  
set @TestCaseLogID = SCOPE_IDENTITY()    
insert into AMS_TestcaseLogDescription(TestcaseLogID,TestSteps,ExpectedResult)    
values(@TestCaseLogID,@TestSteps,@ExpectedResult)  
                    
END                    
else                    
begin                    
                    
update AMS_Testcase set  
TestcaseName = @TestcaseName,  
Complexity = @Complexity,  
Severity = @Severity,  
TestcaseType = @TestcaseType,  
RegressionRequired = @RegressionRequired,  
LastUpdatedBy = @UserID,          
LastUpdatedDate = GETDATE()                  
where TestcaseID= @TestcaseID  
                    
update AMS_TestcaseDescription set TestSteps = @TestSteps,  
ExpectedResult = @ExpectedResult  
where TestcaseID = @TestcaseID  
                    
insert into AMS_TestcaseLog(TestcaseID,LogCreatedBy,LogCreatedDate,LogType)  
values(@TestcaseID,@UserID,GETDATE(),17)  
set @TestCaseLogID = SCOPE_IDENTITY()    
insert into AMS_TestcaseLogDescription(TestcaseLogID,TestSteps,ExpectedResult)    
values(@TestCaseLogID,@TestSteps,@ExpectedResult)  
end                    
                    
select @TestcaseID  
exec AMS_Get_Testcase @ProjectPhaseID                  
                    
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_UserInfo]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_UserInfo]                          
@UserInfoID INT = -1,                          
@UserName nvarchar(50),                          
@Passwordstring nvarchar(50) = '',        
@FullName nvarchar(50),                          
@CNumber nvarchar(50),                          
@EMail nvarchar(50),                          
@CreatedBy int = 1,        
@RoleID INT,            
@DesignationID int,                  
@ReportingLeadID INT = -1,      
@Gender bit,      
@JoiningDate date,      
@DOB date,  
@DepartmentID int,  
@EmployeeStatus Bit,  
@EnableAssessment Bit  
AS                          
BEGIN                          
SET NOCOUNT ON;                          
BEGIN TRY                          
BEGIN TRAN                          
if(@UserInfoID <= 0)                          
begin                          
                          
INSERT INTO [dbo].[AMS_UserInfo]                          
           ([UserName]                          
           ,[Passwordstring]                          
           ,[FullName]                          
           ,[CNumber]                          
           ,[EMail]                          
           ,[CreatedBy]                          
           ,[CreatedDate],                  
           DesignationID,                  
           ReportingLeadID,            
           RoleID,          
     IsOTP,JoingDate,DOB,Gender,DepatmentID,EmployeeStatus,EnableAssessmnet,HR)                          
     VALUES                          
           (                          
@UserName,                          
@Passwordstring,                          
@FullName,                          
@CNumber,                          
@EMail,                          
@CreatedBy,                          
dbo.AMS_GetLocalDate(GETUTCDATE()),                  
@DesignationID,                  
@ReportingLeadID,            
@RoleID,          
1,@JoiningDate,@DOB,@Gender,@DepartmentID,@EmployeeStatus,@EnableAssessment,15)                          
set @UserInfoID = SCOPE_IDENTITY()                          
                    
end                          
else                          
begin                          
                          
UPDATE [dbo].[AMS_UserInfo]                          
   SET                           
   [FullName] = @FullName,                          
   [CNumber] = @CNumber,                          
   [EMail] = @EMail,                          
   [CreatedBy] = @CreatedBy,                  
   DesignationID = @DesignationID,                  
   ReportingLeadID = @ReportingLeadID     ,            
   RoleID = @RoleID,    
   JoingDate = @JoiningDate,    
   DOB = @DOB,    
   Gender = @Gender,  
   DepatmentID = @DepartmentID,  
   EmployeeStatus = @EmployeeStatus,  
   EnableAssessmnet = @EnableAssessment  
   where UserInfoID = @UserInfoID                          
                          
end                          
select @UserInfoID as UserInfoID                          
exec AMS_Get_UserInfo                
COMMIT TRAN                          
END TRY                          
BEGIN CATCH                          
SELECT ERROR_MESSAGE() AS ErrorMessage                          
IF(@@TRANCOUNT > 0)                          
ROLLBACK TRAN                          
END CATCH                          
END   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_WorkPlaceRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_WorkPlaceRatings]    
@AssessmentYearID int,    
@AssessmentModeID int,    
@EmployeeID int,    
@Improvements nvarchar(max) = '',
@Appreciations nvarchar(max) = '',    
@AditionalContributions INT = 2,
@AdtionalRole nvarchar(500) = '',    
@dtRatings AMS_dtWorkplaceRatings readonly    
as    
begin    
    
IF NOT EXISTS (SELECT 1 FROM AMS_WorkPlaceRatingsComments WHERE EmployeeID = @EmployeeID   
AND AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID)  
BEGIN  
  
INSERT INTO AMS_WorkPlaceRatingsComments(EmployeeID,AssessmentYearID,AssessmentModeID,  
Improvements,Appreciations,AditionalContributions,AdtionalRole)  
VALUES(@EmployeeID,@AssessmentYearID,@AssessmentModeID,  
@Improvements,@Appreciations,@AditionalContributions,@AdtionalRole)  
  
END  
ELSE   
BEGIN  
  
UPDATE AMS_WorkPlaceRatingsComments SET   
Improvements = @Improvements,  
Appreciations = @Appreciations,  
AditionalContributions = @AditionalContributions,  
AdtionalRole = @AdtionalRole  
WHERE AssessmentYearID = @AssessmentYearID AND AssessmentModeID = @AssessmentModeID  
AND EmployeeID = @EmployeeID   
END  
  
DELETE FROM AMS_WorkPlaceRatingsMap WHERE AssessmentYearID = @AssessmentYearID   
AND AssessmentModeID = @AssessmentModeID AND EmployeeID = @EmployeeID  
  
INSERT INTO AMS_WorkPlaceRatingsMap(EmployeeID,AssessmentYearID,AssessmentModeID,WorkPlaceRatingsID,Rating)  
SELECT @EmployeeID,@AssessmentYearID,@AssessmentModeID,  
WorkPlaceRatingsID,Rating FROM @dtRatings  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Ins_WorkType]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Ins_WorkType]  
@WorkTypeID int = 0,    
@WorkTypeDecription nvarchar(100),    
@SubTaskID int    
as    
begin    
    
if(@WorkTypeID = 0)    
begin    
insert into AMS_WorkType(WorkTypedescription,SubTaskID)    
values(@WorkTypeDecription,@SubTaskID)    
set @WorkTypeID = SCOPE_IDENTITY()    
end    
else    
begin    
    
update AMS_WorkType set WorkTypedescription = @WorkTypeDecription,    
 SubTaskID = @SubTaskID where WorkTypeID = @WorkTypeID    
    
end    
    
select @WorkTypeID    
exec AMS_Get_WorkType    
    
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_CFLeaves]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Job_CFLeaves]          
AS          
BEGIN          
          
DECLARE @FYearID int  = 0    
SELECT top(1) @FYearID = ISNULL(FYearID,0) FROM AMS_FYear             
WHERE CONVERT(DATE,FromDate) <= CONVERT(DATE,dbo.AMS_GetLocalDate(GETUTCDATE()))     
order by FromDate DESC    
    
if(ISNULL(@FYearID,0) = 0)          
return;    
    
IF NOT EXISTS(SELECT 1 FROM AMS_LeaveCF WHERE FYearID = @FYearID)    
BEGIN          
    
DECLARE @OFYearID int,@OFromDate Date,@OToDate Date          
SELECT top(1) @OFYearID = FYearID,          
@OFromDate = FromDate,          
@OToDate = dbo.LDOMonth(ToDate)          
FROM AMS_FYear             
WHERE CONVERT(DATE,FromDate) <= CONVERT(DATE,dbo.AMS_GetLocalDate(GETUTCDATE() - 30))
order by FromDate DESC    

CREATE TABLE #LDetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT)            
INSERT INTO #LDetails(EmployeeID,JoiningDate,LeaveTypeID)            
SELECT UserInfoID,JoingDate,1          
FROM AMS_UserInfo where RoleID <> 1 AND ISNULL(EmployeeStatus,1) = 1  
          
CREATE TABLE #ODetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT,          
ProrataLeaves DECIMAL(10,2),LeavesAvailed DECIMAL(10,2))            
          
INSERT INTO #ODetails(EmployeeID,JoiningDate,LeaveTypeID,          
ProrataLeaves,LeavesAvailed)          
SELECT            
E.EmployeeID,E.JoiningDate,E.LeaveTypeID,          
LCF.Quantity + DATEDIFF(Month,CASE WHEN @OFromDate < JoiningDate           
THEN JoiningDate ELSE @OFromDate END,@OToDate) + 1  AS ProrataLeaves,            
ISNULL(EL.LeaveDays,0) AS LeavesAvailed          
          
FROM #LDetails E LEFT JOIN AMS_LeaveCF LCF             
on E.EmployeeID = LCF.EmployeeID            
left join             
(select EmployeeID,          
ISNULL(SUM(LeaveDays),0) AS LeaveDays from AMS_EmployeeLeave          
where FYearID = @OFYearID and LeaveTypeID = 1          
and (LeaveStatusID = 1 OR LeaveStatusID = 4 OR LeaveStatusID = 5)           
group by EmployeeID) EL on E.EmployeeID = EL.EmployeeID          
where LCF.FYearID = @OFYearID            

INSERT INTO AMS_LeaveCF(EmployeeID,FYearID,LeaveTypeID,Quantity)          
SELECT EmployeeID,@FYearID,LeaveTypeID,          
case when ISNULL(ProrataLeaves,0) - ISNULL(LeavesAvailed,0) <= 5         
then ISNULL(ProrataLeaves,0) - ISNULL(LeavesAvailed,0) else 5 end FROM #ODetails          
        
SELECT UserInfoID AS EmployeeID,FullName,EMail FROM AMS_UserInfo    
WHERE ISNULL(EmployeeStatus,1) = 1  
         
END          
          
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_CompOffStatus]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Job_CompOffStatus]    
AS    
BEGIN    
  
DECLARE @CompOffExpiryDays int  
select @CompOffExpiryDays = CAST(LookupValue as int) from AMS_Lookup where LookupID = 12  

select CL.EmployeeID,E.FullName,E.EMail from (select distinct EmployeeID from AMS_CompensatoryLeave
WHERE CONVERT(DATE, LeaveDate) < CONVERT(DATE, GETDATE() - @CompOffExpiryDays)    
AND LeaveStatus IN (1,5,7)) CL INNER JOIN AMS_UserInfo E on CL.EmployeeID = E.UserInfoID

select EmployeeID,LeaveDate from AMS_CompensatoryLeave
WHERE CONVERT(DATE, LeaveDate) < CONVERT(DATE, GETDATE() - @CompOffExpiryDays)    
AND LeaveStatus IN (1,5,7)    

UPDATE AMS_CompensatoryLeave SET LeaveStatus = 3    
WHERE  CONVERT(DATE, LeaveDate) < CONVERT(DATE, GETDATE() - @CompOffExpiryDays)    
AND LeaveStatus IN (1,5,7)    
    
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetLeaveBalance]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Job_GetLeaveBalance]                  
AS                    
BEGIN                    
    
DECLARE @LeaveBalNotificationDay int      
select @LeaveBalNotificationDay = CAST(LookupValue as int) from AMS_Lookup where LookupID = 14    
                  
if(DAY(dbo.AMS_GetLocalDate(GETUTCDATE())) <> @LeaveBalNotificationDay)                  
return;                  
                
SELECT UserInfoID AS EmployeeID,                
FullName,EMail FROM AMS_UserInfo                 
WHERE RoleID <> 1 and ISNULL(EmployeeStatus,1) = 1  
                
DECLARE @FYearID int,@Fromdate date,@ToDate date                    
SELECT top(1) @FYearID = FYearID,                    
@Fromdate = FromDate,                    
@ToDate = DBO.LDOMonth(ToDate)                     
FROM AMS_FYear                     
WHERE CONVERT(DATE,FromDate) <= CONVERT(DATE,dbo.AMS_GetLocalDate(GETUTCDATE()))
order by FromDate desc
                    
CREATE TABLE #LDetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT)                    
INSERT INTO #LDetails(EmployeeID,JoiningDate,LeaveTypeID)                    
SELECT UserInfoID,JoingDate,LeaveTypeID                    
FROM AMS_UserInfo,AMS_LeaveType where RoleID <> 1 and LeaveTypeID IN (1,2,3,4)                    
and ISNULL(EmployeeStatus,1) = 1  
                    
CREATE TABLE #ODetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT,                    
TotalLeaves DECIMAL(10,2),ProrataLeaves DECIMAL(10,2),LeavesAvailed DECIMAL(10,2))                    
                    
INSERT INTO #ODetails(EmployeeID,JoiningDate,LeaveTypeID,TotalLeaves,                    
ProrataLeaves,LeavesAvailed)                    
SELECT                    
E.EmployeeID,E.JoiningDate,E.LeaveTypeID,                    
case when E.LeaveTypeID = 1 then LCF.Quantity +                    
DATEDIFF(MONTH, CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,@Todate) + 1                    
when E.LeaveTypeID = 2 or E.LeaveTypeID = 3 then                    
CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,@Todate) + 1 as decimal(10,2))/2                    
else 0 end  AS TotalLeaves,                    
case when E.LeaveTypeID = 1                    
then LCF.Quantity + DATEDIFF(Month,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END                    
,dbo.AMS_GetLocalDate(GETUTCDATE())) + 1                    
when E.LeaveTypeID = 2                    
then CAST(DATEDIFF(Month,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,                    
dbo.AMS_GetLocalDate(GETUTCDATE()))+1 as decimal(10,2))/2                    
when E.LeaveTypeID = 3 then CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,                    
@Todate) + 1 as decimal(10,2))/2                    
else 0 end  AS ProrataLeaves,                    
ISNULL(EL.LeaveDays,0) AS LeavesAvailed                    
FROM #LDetails E LEFT JOIN AMS_LeaveCF LCF                     
on E.EmployeeID = LCF.EmployeeID                    
left join                     
(select EmployeeID,LeaveTypeID,                    
ISNULL(SUM(LeaveDays),0) AS LeaveDays from AMS_EmployeeLeave                    
where FYearID = @FYearID                    
and (LeaveStatusID = 1 OR LeaveStatusID = 4 OR LeaveStatusID = 5)                    
group by EmployeeID,LeaveTypeID) EL                    
on E.EmployeeID = EL.EmployeeID and E.LeaveTypeID = EL.LeaveTypeID                    
where LCF.FYearID = @FYearID                    
                    
SELECT O.EmployeeID,O.LeaveTypeID,LT.LeaveTypeName,                
O.TotalLeaves,O.ProrataLeaves,O.LeavesAvailed,                
case when (O.LeaveTypeID = 1 OR O.LeaveTypeID = 2 OR O.LeaveTypeID = 3) then                
ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0)                
when O.LeaveTypeID = 4 then ISNULL(CL.LeaveDays,0) end  AS LeaveBalance                
FROM #ODetails O left join (SELECT EmployeeID,4 AS LeaveTypeID,                
SUM(leavedays - AvailedDays) As LeaveDays FROM AMS_CompensatoryLeave                
where LeaveStatus in(1,5,7) group by EmployeeID) CL                
on O.EmployeeID = cl.EmployeeID AND O.LeaveTypeID = cl.LeaveTypeID                
left join AMS_LeaveType LT on O.LeaveTypeID = LT.LeaveTypeID                
                
DROP TABLE #LDetails                
DROP TABLE #ODetails                
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetMissedCompOff]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AMS_Job_GetMissedCompOff]            
as                          
begin                          
      
DECLARE @Misseddays int            
select @Misseddays = CAST(LookupValue as int) from AMS_Lookup where LookupID = 11          
      
DECLARE @mydate DATETIME = dbo.AMS_GetLocalDate(getutcdate()-1)                                
Declare @Days Table (ID int identity(1,1) not null, DateField date, DayField varchar(50))                                          
Declare @CurrentDate datetime                                          
Declare @EndDate datetime                                          
      
SELECT @CurrentDate = @mydate - @Misseddays          
SELECT @EndDate = @mydate                          
      
While CONVERT(date,@CurrentDate) <= CONVERT(date,@EndDate)    
Begin                                          
IF(DATEPART(dw , @CurrentDate) = 1 or DATEPART(dw , @CurrentDate) = 7)                        
BEGIN                        
Insert Into @Days Values(@CurrentDate, DATEPART(dw , @CurrentDate))                                          
END                        
ELSE IF EXISTS(SELECT 1 FROM AMS_HoliDay WHERE CONVERT(date,HolidayDate) = CONVERT(date,@CurrentDate))                        
BEGIN                        
Insert Into @Days Values(CONVERT(date, @CurrentDate), DATEPART(dw , @CurrentDate))            
END            
Set @CurrentDate = DateAdd(d,1,@CurrentDate)                                          
End                                          
      
CREATE TABLE #TDays (ID int,DayDate date,EmployeeID int,TimesheetID int)                    
INSERT INTO #TDays(DayDate,EmployeeID,TimesheetID)            
SELECT D.DateField,T.EmployeeID,T.TimesheetID                     
FROM @Days D LEFT JOIN AMS_TimeSheet T ON CONVERT(date,D.DateField) = CONVERT(DATE,T.LogDate)      
where not exists (select * from AMS_CompensatoryLeave CL                     
where CL.LeaveDate = D.DateField and CL.EmployeeID = T.EmployeeID        
and LeaveStatus not in (2,6))        
and (T.DayMins >  180 OR T.TimesheetID IS NOT NULL)      
      
select distinct                
D.EmployeeID,U.EMail,RL.EMail AS ReportingLeadEmail,H.EMail AS HRMail,      
U.FullName      
from #TDays D inner join AMS_UserInfo U on D.EmployeeID = U.UserInfoID      
inner join AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID      
inner join AMS_UserInfo H on U.HR = H.UserInfoID      
where ISNULL(EmployeeStatus,1) = 1
      
select DayDate,EmployeeID from #TDays                
      
end   
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetMissedTaskEntry]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Job_GetMissedTaskEntry]            
AS            
BEGIn            
    
DECLARE @Misseddays int      
select @Misseddays = CAST(LookupValue as int) from AMS_Lookup where LookupID = 11    
            
CREATE TABLE #MDays(LogDate DATE,EmployeeID INT)        
        
insert into #MDays(LogDate,EmployeeID)        
Select T.LogDate,            
T.EmployeeID             
from AMS_TimeSheet T left JOIN             
(SELECT TimesheetID,ISNULL(SUM(TaskHours),0) AS DayMins FROM AMS_EmployeeTask            
group by TimesheetID)            
ET ON T.TimesheetID = ET.TimesheetID            
where CONVERT (DATE,LogDate) > CONVERT(DATE,dbo.AMS_GetLocalDate(GETUTCDATE())- @Misseddays)   
AND CONVERT (DATE,LogDate) < CONVERT(DATE,dbo.AMS_GetLocalDate(GETUTCDATE())- 1)   
and (ISNULL(T.DayMins,0) <> ISNULL(ET.DayMins,0) OR ISNULL(T.DayMins,0) = 0)            
        
select distinct        
D.EmployeeID,U.EMail,RL.EMail AS ReportingLeadEmail,H.EMail AS HRMail,      
U.FullName      
from #MDays D inner join AMS_UserInfo U on D.EmployeeID = U.UserInfoID            
inner join AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID            
inner join AMS_UserInfo H on U.HR = H.UserInfoID            
      
select LogDate,EmployeeID from #MDays      
      
drop table #MDays      
            
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetMissedTimesheet]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Job_GetMissedTimesheet]                              
AS                              
BEGIN                              
              
DECLARE @Misseddays int                
select @Misseddays = CAST(LookupValue as int) from AMS_Lookup where LookupID = 11              
                              
DECLARE @mydate DATETIME = dbo.AMS_GetLocalDate(getutcdate()-1)                                    
Declare @Days Table (ID int identity(1,1) not null, DateField datetime, DayField varchar(50))                                              
Declare @CurrentDate datetime                                              
Declare @EndDate datetime                                              
                                              
SELECT @CurrentDate = @mydate - @Misseddays  
SELECT @EndDate = @mydate                              
                                              
While @CurrentDate <= @EndDate                                              
Begin                                              
                        
if(DATEPART(dw , @CurrentDate) = 2 OR DATEPART(dw , @CurrentDate) = 3 OR DATEPART(dw , @CurrentDate) = 4 OR                          
DATEPART(dw , @CurrentDate) = 5 OR DATEPART(dw , @CurrentDate) = 6)                          
BEGIN                          
IF NOT EXISTS(SELECT 1 FROM AMS_HoliDay H WHERE CONVERT(date,HolidayDate) = CONVERT(date,@CurrentDate))          
BEGIN  
Insert Into @Days Values(@CurrentDate, DATEPART(dw , @CurrentDate))  
END  
END  
Set @CurrentDate = DateAdd(d,1,@CurrentDate)                                              
End  
                        
create TABLE #TDays (ID int,DayDate date,DayField int,EmployeeID int)                              
insert into #TDays                              
select D.ID,D.DateField,DayField,U.UserInfoID from @Days D,AMS_UserInfo U                              
where U.JoingDate < (@mydate - @Misseddays) and U.RoleID <> 1 and ISNULL(EmployeeStatus,1) = 1
                        
create TABLE #WDays(DayDate date,EmployeeID int)                        
insert into #WDays(DayDate,EmployeeID)                        
select D.DayDate,D.EmployeeID from #TDays D left join  AMS_TimeSheet T                        
on D.EmployeeID = T.EmployeeID and D.DayDate = T.LogDate                        
where (T.TimesheetID is null OR DayMins < 360) AND NOT EXISTS             
(SELECT 1 FROM AMS_EmployeeLeave EL where             
D.EmployeeID = EL.EmployeeID and D.DayDate >= EL.LeaveFromDate                         
and D.DayDate <= EL.LeaveToDate and LeaveStatusID not in (2,6))                      
                      
select DISTINCT D.EmployeeID,U.EMail,RL.EMail AS ReportingLeadEmail,H.EMail AS HRMail,                    
U.FullName                    
FROM #WDays D inner join AMS_UserInfo U on D.EmployeeID = U.UserInfoID                          
inner join AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID                          
inner join AMS_UserInfo H on U.HR = H.UserInfoID                          
                      
SELECT DayDate,EmployeeID FROM #WDays                      
                      
DROP TABLE #TDays                      
DROP TABLE #WDays                      
                      
END 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_GetServiceConfiguration]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Job_GetServiceConfiguration]  
AS  
BEGIN  
  
select LookupValue from AMS_Lookup where MapID = 7
order by LookupID
  
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Job_UpdateLeaveStatus]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AMS_Job_UpdateLeaveStatus]  
AS  
BEGIN  
  
update AMS_EmployeeLeave SET LeaveStatusID = 4  
where (LeaveStatusID = 1  OR LeaveStatusID = 5)
AND LeaveToDate < DBO.AMS_GetLocalDate(GETUTCDATE())  
  
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_RoleandDesignations]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[AMS_RoleandDesignations]    
as    
begin    

SELECT * FROM AMS_Role
   
select * from AMS_Designation    
    
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_DAssessment]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_DAssessment]    
@AssessmentYearID INT,    
@AssessmentModeID INT,    
@EmployeeID INT    
AS    
begin    
    
declare @RoleID INT = 0    
SELECT @RoleID = RoleID FROM AMS_UserInfo WHERE UserInfoID = @EmployeeID    

exec AMS_Rpt_WorkplaceRatings @EmployeeID,@AssessmentYearID,@AssessmentModeID  
EXEC AMS_Rpt_TechnicalRatingsForDS @AssessmentYearID,@AssessmentModeID,@EmployeeID    
EXEC AMS_Rpt_ProjectRatingsForDS @AssessmentYearID,@AssessmentModeID,@EmployeeID    
EXEC AMS_Rpt_LeadRatingsForDS @AssessmentYearID,@AssessmentModeID,@EmployeeID    
EXEC AMS_Rpt_LeadCommentsForDS @AssessmentYearID,@AssessmentModeID,@EmployeeID    
EXEC AMS_Rpt_GeneralRatingsForDS @AssessmentYearID,@AssessmentModeID,@EmployeeID    
exec  AMS_Rpt_SelfGoals @EmployeeID,@AssessmentYearID, @AssessmentModeID  
exec  AMS_Rpt_MGoals @EmployeeID,@AssessmentYearID, @AssessmentModeID  
IF(@RoleID = 4)    
BEGIN    
EXEC AMS_Get_FinalRating @AssessmentYearID,@AssessmentModeID,@EmployeeID    
END    
ELSE    
BEGIN    
EXEC AMS_Get_FinalRatingWithLR @AssessmentYearID,@AssessmentModeID,@EmployeeID    
END    
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_GeneralRatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_GeneralRatingsForDS]    
@AssessmentYearID INT,            
@AssessmentModeID INT,            
@EmployeeID INT = -1    
AS    
BEGIN    
    
SELECT      
GR.GeneralPerformanceID,            
GP.RatingName,            
GP.RatingDescription,      
cast(S.SA as decimal(18,2)) as SA,          
cast(M.MA  as decimal(18,2)) as MA    
from AMS_GenaralRatings GR             
inner join AMS_GeneralPerformance GP on GR.GeneralPerformanceID = GP.GeneralPerformanceID            
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID      
INNER JOIN (SELECT GeneralPerformanceID,Rating AS SA       
FROM AMS_GenaralRatings WHERE AssessmentYearID = @AssessmentYearID    
and AssessmentModeID = @AssessmentModeID
 and UserInfoID = @EmployeeID AND RatingUserID = @EmployeeID) S       
ON GR.GeneralPerformanceID = S.GeneralPerformanceID      
inner join (SELECT GeneralPerformanceID, AVG(Rating) AS MA      
FROM AMS_GenaralRatings WHERE AssessmentYearID = @AssessmentYearID    
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID  group by GeneralPerformanceID)M       
ON GR.GeneralPerformanceID = M.GeneralPerformanceID      
where GR.AssessmentYearID = @AssessmentYearID     
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID     
and GR.RatingUserID = @EmployeeID    
    
END  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_GetLeaveBalance]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_GetLeaveBalance]        
@FYearID int = 0        
AS                          
BEGIN                          
          
DECLARE @Fromdate date,@ToDate date        
SELECT @Fromdate = FromDate,                          
@ToDate = DBO.LDOMonth(ToDate)                           
FROM AMS_FYear where FYearID = @FYearID        
                          
CREATE TABLE #LDetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT)                          
INSERT INTO #LDetails(EmployeeID,JoiningDate,LeaveTypeID)                          
SELECT UserInfoID,JoingDate,LeaveTypeID                          
FROM AMS_UserInfo,AMS_LeaveType where RoleID <> 1         
and LeaveTypeID IN (1,2,3,4)        
and ISNULL(EmployeeStatus,1) = 1        
      
CREATE TABLE #ODetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT,                          
TotalLeaves DECIMAL(10,2),ProrataLeaves DECIMAL(10,2),LeavesAvailed DECIMAL(10,2))                          
                          
INSERT INTO #ODetails(EmployeeID,JoiningDate,LeaveTypeID,TotalLeaves,                          
ProrataLeaves,LeavesAvailed)                          
SELECT                          
E.EmployeeID,E.JoiningDate,E.LeaveTypeID,                          
  
case when @ToDate < JoiningDate  then 0 else    
case when E.LeaveTypeID = 1 then ISNULL(LCF.Quantity,0) +                          
DATEDIFF(MONTH, CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,@Todate) + 1    
when E.LeaveTypeID = 2 or E.LeaveTypeID = 3 then                          
CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < JoiningDate THEN     
JoiningDate ELSE @Fromdate END,@Todate) + 1 as decimal(10,2))/2                          
else 0 end end AS TotalLeaves,                          
    
case when @ToDate < JoiningDate then 0 else    
case when E.LeaveTypeID = 1                          
then ISNULL(LCF.Quantity,0) + DATEDIFF(Month,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END    
,CASE WHEN @Todate < dbo.AMS_GetLocalDate(GETUTCDATE()) then @Todate else dbo.AMS_GetLocalDate(GETUTCDATE()) end) + 1    
when E.LeaveTypeID = 2    
then CAST(DATEDIFF(Month,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,    
CASE WHEN @Todate < dbo.AMS_GetLocalDate(GETUTCDATE()) then @Todate else dbo.AMS_GetLocalDate(GETUTCDATE()) end)+1 as decimal(10,2))/2    
when E.LeaveTypeID = 3 then CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,    
@Todate) + 1 as decimal(10,2))/2                          
else 0 end end AS ProrataLeaves,    
    
ISNULL(EL.LeaveDays,0) AS LeavesAvailed    
    
FROM #LDetails E LEFT JOIN AMS_LeaveCF LCF on E.EmployeeID = LCF.EmployeeID      
and  LCF.FYearID = @FYearID                          
left join (select EmployeeID,LeaveTypeID,                          
ISNULL(SUM(LeaveDays),0) AS LeaveDays from AMS_EmployeeLeave                          
where FYearID = @FYearID                          
and (LeaveStatusID = 1 OR LeaveStatusID = 4 OR LeaveStatusID = 5)                          
group by EmployeeID,LeaveTypeID) EL                          
on E.EmployeeID = EL.EmployeeID and E.LeaveTypeID = EL.LeaveTypeID      
                          
SELECT U.UserName,U.FullName,O.EmployeeID,O.LeaveTypeID,LT.LeaveTypeName,                      
O.TotalLeaves,O.ProrataLeaves,O.LeavesAvailed,                      
case when (O.LeaveTypeID = 1 OR O.LeaveTypeID = 2 OR O.LeaveTypeID = 3) then                      
ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0)                      
when O.LeaveTypeID = 4 then ISNULL(CL.LeaveDays,0) end  AS LeaveBalance                      
FROM #ODetails O left join (SELECT EmployeeID,4 AS LeaveTypeID,                      
SUM(leavedays - AvailedDays) As LeaveDays FROM AMS_CompensatoryLeave                      
where LeaveStatus in(1,5,7) group by EmployeeID) CL                      
on O.EmployeeID = cl.EmployeeID AND O.LeaveTypeID = cl.LeaveTypeID                      
left join AMS_LeaveType LT on O.LeaveTypeID = LT.LeaveTypeID                      
left join AMS_UserInfo U ON O.EmployeeID = U.UserInfoID        
                   
DROP TABLE #LDetails                      
DROP TABLE #ODetails                      
END 
GO
/****** Object:  StoredProcedure [dbo].[AMS_rpt_LeadCommentsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AMS_rpt_LeadCommentsForDS]  
@AssessmentYearID INT,              
@AssessmentModeID INT,              
@EmployeeID INT = -1      
as  
begin  
  
DECLARE @SComments NVARCHAR(MAX)                                      
SELECT @SComments =                                       
COALESCE(@SComments + ',','') + CAST(Comments AS VARCHAR(max))      
FROM (SELECT Comments FROM AMS_LeadRatings      
where AssessmentYearID = @AssessmentYearID  
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID  and RatingUserID = @EmployeeID) AS A        
        
DECLARE @MComments NVARCHAR(MAX)                                      
SELECT @MComments =                                       
COALESCE(@MComments + ',','') + CAST(Comments AS VARCHAR(max))        
FROM (SELECT Comments FROM AMS_LeadRatings      
where AssessmentYearID = @AssessmentYearID      
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID and RatingUserID <> @EmployeeID ) AS A        
      
      
select REPLACE(@SComments,',',CHAR(10) + CHAR(13)) AS SelfComments,      
REPLACE(@MComments,',',CHAR(10) + CHAR(13)) AS ManagementComments      
  
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeadRatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_LeadRatingsForDS]      
@AssessmentYearID INT,              
@AssessmentModeID INT,              
@EmployeeID INT = -1      
AS      
BEGIN      
      
SELECT          
GR.LeadPerformanceID,                
GP.RatingName,                
GP.RatingDescription,          
cast(S.SA as decimal(18,2)) as SA,          
cast(M.MA  as decimal(18,2)) as MA    
from AMS_LeadRatings GR                 
inner join AMS_LeadPerformance GP on GR.LeadPerformanceID = GP.LeadPerformanceID                
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID          
  
INNER JOIN (SELECT LeadPerformanceID,Rating AS SA           
FROM AMS_LeadRatings WHERE AssessmentYearID = @AssessmentYearID      
and AssessmentModeID = @AssessmentModeID
 and UserInfoID = @EmployeeID AND RatingUserID = @EmployeeID ) S           
ON GR.LeadPerformanceID = S.LeadPerformanceID          
  
inner join (SELECT LeadPerformanceID, AVG(Rating) AS MA          
FROM AMS_LeadRatings WHERE AssessmentYearID = @AssessmentYearID      
and AssessmentModeID = @AssessmentModeID
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID group by LeadPerformanceID)M           
ON GR.LeadPerformanceID = M.LeadPerformanceID          
  
where GR.AssessmentYearID = @AssessmentYearID      
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID      
and GR.RatingUserID = @EmployeeID  
  
  
      
END  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeaveBalance]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Rpt_LeaveBalance]
@FYearID int
AS
BEGIN

CREATE TABLE #LDetails(EmployeeID int, 
LeaveTypeID int, 
TotalLeaves decimal(10,2),
ProrataLeaves decimal(10,2),
LeavesAvailed decimal(10,2),
LeaveBalance decimal(10,2)
)

insert into #LDetails(EmployeeID,LeaveTypeID)
select UserInfoID,LeaveTypeID from AMS_UserInfo,AMS_LeaveType
where LeaveTypeID in (1,2,3,4) 
and ISNULL(EmployeeStatus,1) = 1

select * from #LDetails



END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeaveCalendar]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Rpt_LeaveCalendar]     
@SelectedMonth date = NULL,
@RoleID int = 0,
@UserID int = 0
AS      
BEGIN      
      
DECLARE @mydate DATETIME = @SelectedMonth    
Declare @Days Table (ID int identity(1,1) not null,             
DateField DATE,             
DayField int,            
DayNme nvarchar(50),            
DayID int)              
Declare @CurrentDate datetime                                        
Declare @EndDate datetime                                        
                                        
SELECT @CurrentDate = DATEADD(dd,-(DAY(@mydate)-1),@mydate)                                        
SELECT @EndDate =DATEADD(dd,-(DAY(DATEADD(mm,1,@mydate))),DATEADD(mm,1,@mydate))                                        
                                        
While @CurrentDate <= @EndDate                                        
Begin                                        
 Insert Into @Days               
 Values(@CurrentDate,              
 DATEPART(dw, @CurrentDate),              
 DATENAME(dw , @CurrentDate),              
 CAST(DAY(@CurrentDate) AS varchar(2)) + CAST(MONTH(@CurrentDate) AS varchar(2)) + CAST(YEAR(@CurrentDate) AS varchar(4)))          
 Set @CurrentDate = DateAdd(d,1,@CurrentDate)                                        
End                                        
      
CREATE TABLE #EDetals(EmployeeID INT,FullName nvarchar(50),DateField Date,DayField int,DayNme nvarchar(10),DayID int)      
      
INSERT INTO #EDetals(EmployeeID,FullName,DateField,DayField,DayNme,DayID)      
SELECT UserInfoID,FullName,DateField,DayField,DayNme,DayID      
FROM AMS_UserInfo,@Days WHERE RoleID <> 1 
and ISNULL(EmployeeStatus,1) = 1
      
SELECT E.EmployeeID,FullName,    
DAY(DateField) AS DateField,    
SUBSTRING(DayNme,0,4) AS DayNme,    
DayField,DayID,      
CASE WHEN EL.EmployeeLeaveID IS NULL THEN '' ELSE     
CASE WHEN LT.LeaveTypeID = 1 THEN 'P/L'    
WHEN LT.LeaveTypeID = 2 THEN 'C/L'    
WHEN LT.LeaveTypeID = 3 THEN 'S/L'    
WHEN LT.LeaveTypeID = 4 THEN 'COMP/L'    
WHEN LT.LeaveTypeID = 5 THEN 'LOP'    
WHEN LT.LeaveTypeID = 6 THEN 'M/L'    
WHEN LT.LeaveTypeID = 7 THEN 'PAT/L'    
WHEN LT.LeaveTypeID = 8 THEN 'SHIF/L' ELSE NULL END    
END AS EmployeeOnLeave      
FROM #EDetals E LEFT JOIN AMS_EmployeeLeave EL      
ON E.EmployeeID = EL.EmployeeID and LeaveStatusID in(1,4,5)  
AND E.DateField >= EL.LeaveFromDate AND E.DateField <= EL.LeaveToDate  
LEFT JOIN AMS_LeaveType LT ON EL.LeaveTypeID = LT.LeaveTypeID     
      
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_LeaveReportYearly]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_LeaveReportYearly]
@FYearID int
AS
BEGIN

DECLARE @Fromdate date,@ToDate date      
SELECT @Fromdate = FromDate,                        
@ToDate = DBO.LDOMonth(ToDate)                         
FROM AMS_FYear where FYearID = @FYearID      
                        
CREATE TABLE #LDetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT)                        
INSERT INTO #LDetails(EmployeeID,JoiningDate,LeaveTypeID)                        
SELECT UserInfoID,JoingDate,LeaveTypeID                        
FROM AMS_UserInfo,AMS_LeaveType where RoleID <> 1       
and LeaveTypeID IN (1,2,3,4)      
and ISNULL(EmployeeStatus,1) = 1      
    
CREATE TABLE #ODetails(EmployeeID INT,JoiningDate DATE,LeaveTypeID INT,                        
TotalLeaves DECIMAL(10,2),ProrataLeaves DECIMAL(10,2),LeavesAvailed DECIMAL(10,2))                        
                        
INSERT INTO #ODetails(EmployeeID,JoiningDate,LeaveTypeID,TotalLeaves,                        
ProrataLeaves,LeavesAvailed)                        
SELECT                        
E.EmployeeID,E.JoiningDate,E.LeaveTypeID,                        
  
case when @ToDate < JoiningDate  then 0 else  
case when E.LeaveTypeID = 1 then ISNULL(LCF.Quantity,0) +                        
DATEDIFF(MONTH, CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,@Todate) + 1  
when E.LeaveTypeID = 2 or E.LeaveTypeID = 3 then                        
CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < JoiningDate THEN   
JoiningDate ELSE @Fromdate END,@Todate) + 1 as decimal(10,2))/2                        
else 0 end end AS TotalLeaves,                        
  
case when @ToDate < JoiningDate then 0 else  
case when E.LeaveTypeID = 1                        
then ISNULL(LCF.Quantity,0) + DATEDIFF(Month,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END  
,CASE WHEN @Todate < dbo.AMS_GetLocalDate(GETUTCDATE()) then @Todate else dbo.AMS_GetLocalDate(GETUTCDATE()) end) + 1  
when E.LeaveTypeID = 2  
then CAST(DATEDIFF(Month,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,  
CASE WHEN @Todate < dbo.AMS_GetLocalDate(GETUTCDATE()) then @Todate else dbo.AMS_GetLocalDate(GETUTCDATE()) end)+1 as decimal(10,2))/2  
when E.LeaveTypeID = 3 then CAST(DATEDIFF(MONTH,CASE WHEN @Fromdate < JoiningDate THEN JoiningDate ELSE @Fromdate END,  
@Todate) + 1 as decimal(10,2))/2                        
else 0 end end AS ProrataLeaves,  
  
ISNULL(EL.LeaveDays,0) AS LeavesAvailed  
  
FROM #LDetails E LEFT JOIN AMS_LeaveCF LCF on E.EmployeeID = LCF.EmployeeID    
and  LCF.FYearID = @FYearID                        
left join (select EmployeeID,LeaveTypeID,                        
ISNULL(SUM(LeaveDays),0) AS LeaveDays from AMS_EmployeeLeave                        
where FYearID = @FYearID                        
and (LeaveStatusID = 1 OR LeaveStatusID = 4 OR LeaveStatusID = 5)                        
group by EmployeeID,LeaveTypeID) EL                        
on E.EmployeeID = EL.EmployeeID and E.LeaveTypeID = EL.LeaveTypeID    

SELECT U.UserName,U.FullName,O.EmployeeID,O.LeaveTypeID,LT.LeaveTypeName,                    
O.TotalLeaves,O.ProrataLeaves,O.LeavesAvailed,                    
case when (O.LeaveTypeID = 1 OR O.LeaveTypeID = 2 OR O.LeaveTypeID = 3) then
ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0)
when O.LeaveTypeID = 4 then ISNULL(CL.LeaveDays,0) end  AS LeaveBalance,

CASE WHEN O.LeaveTypeID = 1 THEN 
CASE WHEN ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0) > 5
THEN 5 ELSE ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0) END
WHEN O.LeaveTypeID = 2 OR O.LeaveTypeID = 3 THEN 0
WHEN o.LeaveTypeID = 4 THEN ISNULL(CL.LeaveDays,0) END AS CFLeaves,

CASE WHEN O.LeaveTypeID = 1 THEN 
CASE WHEN ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0) > 5
THEN ISNULL(O.ProrataLeaves,0) - ISNULL(O.LeavesAvailed,0) - 5
ELSE 0 END
ELSE 0 END AS EncashedLeaves


FROM #ODetails O 
left join (SELECT EmployeeID,4 AS LeaveTypeID,                    
SUM(leavedays - AvailedDays) As LeaveDays FROM AMS_CompensatoryLeave                    
where LeaveStatus in(1,5,7) group by EmployeeID) CL                    
on O.EmployeeID = cl.EmployeeID AND O.LeaveTypeID = cl.LeaveTypeID                    
left join AMS_LeaveType LT on O.LeaveTypeID = LT.LeaveTypeID                    
left join AMS_UserInfo U ON O.EmployeeID = U.UserInfoID      
                 
DROP TABLE #LDetails                    
DROP TABLE #ODetails                    

END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_MGoals]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[AMS_Rpt_MGoals]  
@EmployeeID int,  
@AssessmentYearID int,  
@AssessmentModeID int  
as  
begin  
  
select    
MGoalsAssessment,MGoalForYear,MGoalforHalfYear,MGoalForHalfYearDetails  
from AMS_WorkPlaceRatingsComments   
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID  
and EmployeeID = @EmployeeID  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_ProjectRatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_ProjectRatingsForDS]          
@AssessmentYearID INT,                  
@AssessmentModeID INT,                  
@EmployeeID INT = -1          
AS          
BEGIN          
    
create table #PDetails(    
ProjectUserMapID int,    
ProjectID int,    
UserInfoID int,    
Selfcomments nvarchar(max),    
ManagementComments nvarchar(max),    
ProjectName nvarchar(500),                    
ProjectLead nvarchar(500),            
SA decimal(18,2),    
MA decimal(18,2))    
    
insert into #PDetails(    
ProjectUserMapID,    
ProjectID,    
UserInfoID,    
ProjectName,    
ProjectLead,    
SA,    
MA)    
SELECT PU.ProjectUserMapID,                        
PU.ProjectID,                        
PU.UserInfoID,                        
P.ProjectName,                    
PL.FullName AS ProjectLead,            
cast(S.SA as decimal(18,2)) as SA,                
cast(M.MA  as decimal(18,2)) as MA          
FROM  AMS_ProjectUserMap PU inner join AMS_Projects P on PU.ProjectID = P.ProjectID                        
inner join AMS_UserInfo PL on PU.ProjectLeadID = PL.UserInfoID            
  
LEFT join (SELECT AVG(Rating) AS SA,ProjectUserMapID FROM AMS_ProjectCriteriaMap PC            
WHERE EXISTS(SELECT 1 FROM AMS_ProjectUserMap PU             
where PC.ProjectUserMapID = PU.ProjectUserMapID             
and PU.AssessmentYearID  = @AssessmentYearID 
and PU.AssessmentModeID = @AssessmentModeID
and PU.UserInfoID = @EmployeeID)            
and PC.UserInfoID = @EmployeeID GROUP BY ProjectUserMapID) S on PU.ProjectUserMapID = S.ProjectUserMapID            
  
LEFT join (select AVG(A.Rating) AS MA,A.ProjectUserMapID from             
(SELECT AVG(Rating) as Rating,CriteriaID,ProjectUserMapID FROM AMS_ProjectCriteriaMap PC            
WHERE EXISTS (SELECT 1 FROM AMS_ProjectUserMap PU             
where PC.ProjectUserMapID = PU.ProjectUserMapID             
and PU.AssessmentYearID  = @AssessmentYearID            
and PU.AssessmentModeID = @AssessmentModeID
and PU.UserInfoID = @EmployeeID) and PC.UserInfoID <> @EmployeeID            
GROUP BY CriteriaID,ProjectUserMapID) as A group by A.ProjectUserMapID) M on PU.ProjectUserMapID = M.ProjectUserMapID    
  
WHERE PU.UserInfoID = @EmployeeID       
and AssessmentYearID = @AssessmentYearID      
and AssessmentModeID = @AssessmentModeID
    
DECLARE @ProjectUserMapID INT    
DECLARE @GetProjectUserMapID CURSOR                                            
SET @GetProjectUserMapID = CURSOR FOR                                       
SELECT ProjectUserMapID FROM #PDetails    
    
DECLARE @SComments NVARCHAR(MAX),@MComments NVARCHAR(MAX)                                            
OPEN @GetProjectUserMapID                                            
FETCH NEXT                                            
FROM @GetProjectUserMapID INTO @ProjectUserMapID                                            
WHILE @@FETCH_STATUS = 0                                            
BEGIN                                            
  
SET @SComments = ''  
    
SELECT @SComments =                                     
COALESCE(@SComments + ',','') + CAST(Comments AS VARCHAR(max))      
FROM (SELECT Comments FROM AMS_ProjectCriteriaMap PC      
where ProjectUserMapID = @ProjectUserMapID       
and UserInfoID = @EmployeeID) AS A    
  
SET @MComments = ''  
  
SELECT @MComments =                                     
  COALESCE(@MComments + ',','') + CAST(Comments AS VARCHAR(max))      
  FROM (SELECT Comments FROM AMS_ProjectCriteriaMap PC      
  where ProjectUserMapID = @ProjectUserMapID       
  and UserInfoID <> @EmployeeID) AS A      
    
    
update #PDetails set Selfcomments = @SComments,    
ManagementComments = @MComments    
where ProjectUserMapID = @ProjectUserMapID    
                                            
FETCH NEXT                                            
FROM @GetProjectUserMapID INTO @ProjectUserMapID                                            
END                                            
CLOSE @GetProjectUserMapID                                            
DEALLOCATE @GetProjectUserMapID                                            
    
select ProjectUserMapID,    
ProjectID,    
UserInfoID,    
ProjectName,    
ProjectLead,    
SA,    
MA,    
REPLACE(Selfcomments,',',char(10) + char(13)) as Selfcomments,    
REPLACE(ManagementComments,',',char(10)+char(13)) as ManagementComments    
from #PDetails    
    
END  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessment]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_SelfAssessment]    
@AssessmentYearID INT,        
@AssessmentModeID INT,  
@EmployeeID int        
as        
begin        
  
exec AMS_Rpt_WorkplaceRatings @EmployeeID,@AssessmentYearID,@AssessmentModeID
exec AMS_Rpt_SelfAssessmentTechincalRatings  @AssessmentYearID,@AssessmentModeID, @EmployeeID      
exec AMS_Rpt_SelfAssessmentProjectRatings  @AssessmentYearID, @AssessmentModeID,@EmployeeID      
exec  AMS_Rpt_SelfAssessmentGeneralRatings @AssessmentYearID, @AssessmentModeID,@EmployeeID      
exec  AMS_Rpt_SelfAssessmentLeadRatings @AssessmentYearID, @AssessmentModeID,@EmployeeID    
exec  AMS_Rpt_SelfGoals @EmployeeID,@AssessmentYearID, @AssessmentModeID
exec  AMS_Rpt_MGoals @EmployeeID,@AssessmentYearID, @AssessmentModeID
        
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentGeneralRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentGeneralRatings]  
@AssessmentYearID INT,  
@AssessmentModeID INT,
@EmployeeID int  
as  
begin  
  
select GR.GeneralPerformanceID,                
GP.RatingName,                
GP.RatingDescription,                
GR.Rating as SA from AMS_GenaralRatings GR inner join AMS_GeneralPerformance GP                
on GR.GeneralPerformanceID = GP.GeneralPerformanceID                
where GR.AssessmentYearID = @AssessmentYearID and GR.AssessmentModeID = @AssessmentModeID and
GR.UserInfoID = @EmployeeID  and GR.RatingUserID = @EmployeeID             
  
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentLeadRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentLeadRatings]    
@AssessmentYearID INT,    
@AssessmentModeID INT,
@EmployeeID int    
as    
begin    
    
select GR.LeadPerformanceID,                  
GP.RatingName,                  
GP.RatingDescription,                  
GR.Rating as SA,  
GR.Comments  
from AMS_LeadRatings GR inner join AMS_LeadPerformance GP                  
on GR.LeadPerformanceID = GP.LeadPerformanceID                  
where GR.AssessmentYearID = @AssessmentYearID and GR.AssessmentModeID = @AssessmentModeID and
GR.UserInfoID = @EmployeeID  and GR.RatingUserID = @EmployeeID               
    
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentProjectRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentProjectRatings]  
@AssessmentYearID INT,  
@AssessmentModeID INT,
@EmployeeID int
as  
begin  
  
select  PC.CriteriaID,              
c.CriteriaName,        
c.Description,        
Pc.Rating AS SA,    
PC.Comments,  
PU.ProjectID,  
PU.ProjectLeadID,  
P.ProjectName,  
U.FullName AS ProjectLead  
from AMS_ProjectUserMap PU  
inner join AMS_ProjectCriteriaMap PC  on PC.ProjectUserMapID = PU.ProjectUserMapID  
inner join AMS_Criteria C on PC.CriteriaID = C.CriteriaID                
LEft join AMS_Projects P on PU.ProjectID = P.ProjectID  
LEft join AMS_UserInfo U on PU.ProjectLeadID = U.UserInfoID  
where PU.AssessmentYearID = @AssessmentYearID AND PU.AssessmentModeID = @AssessmentModeID
and PU.UserInfoID = @EmployeeID        
and PC.UserInfoID = @EmployeeID  
  
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfAssessmentTechincalRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_SelfAssessmentTechincalRatings]  
@AssessmentYearID INT,  
@AssessmentModeID INT,
@EmployeeID int  
as  
begin  
  
select GR.TechnicalPerformanceID,                  
GP.RatingName,                  
GP.RatingDescription,                  
GR.Rating as SA from AMS_TechnicalRatings GR inner join AMS_TechnicalPerformance GP                  
on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID    
where GR.AssessmentYearID = @AssessmentYearID and GR.AssessmentModeID = @AssessmentModeID AND
GR.UserInfoID = @EmployeeID  and GR.RatingUserID = @EmployeeID  
  
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_SelfGoals]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[AMS_Rpt_SelfGoals]  
@EmployeeID int,  
@AssessmentYearID int,  
@AssessmentModeID int  
as  
begin  
  
select    
AchivedGoals,SelfGoalForYear,SelfGoalforHalfYear,SelfGoalForHalfYearDetails
from AMS_WorkPlaceRatingsComments   
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID  
and EmployeeID = @EmployeeID  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_TechnicalRatingsForDS]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_TechnicalRatingsForDS]    
@AssessmentYearID INT,            
@AssessmentModeID int,
@EmployeeID INT = -1    
AS    
BEGIN    
    
SELECT        
GR.TechnicalPerformanceID,              
GP.RatingName,              
GP.RatingDescription,        
cast(S.SA as decimal(18,2)) as SA,        
cast(M.MA  as decimal(18,2)) as MA  
from AMS_TechnicalRatings GR               
inner join AMS_TechnicalPerformance GP on GR.TechnicalPerformanceID = GP.TechnicalPerformanceID              
inner join AMS_UserInfo U on GR.RatingUserID = U.UserInfoID        
INNER JOIN (SELECT TechnicalPerformanceID,Rating AS SA         
FROM AMS_TechnicalRatings WHERE AssessmentYearID = @AssessmentYearID    
 and UserInfoID = @EmployeeID AND RatingUserID = @EmployeeID ) S         
ON GR.TechnicalPerformanceID = S.TechnicalPerformanceID        
inner join (SELECT TechnicalPerformanceID, AVG(Rating) AS MA        
FROM AMS_TechnicalRatings WHERE AssessmentYearID = @AssessmentYearID    
and UserInfoID = @EmployeeID AND RatingUserID <> @EmployeeID group by TechnicalPerformanceID)M         
ON GR.TechnicalPerformanceID = M.TechnicalPerformanceID        
where GR.AssessmentYearID = @AssessmentYearID
and GR.AssessmentModeID = @AssessmentModeID
and GR.UserInfoID = @EmployeeID    
and GR.RatingUserID = @EmployeeID    
    
END  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_Timesheet]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AMS_Rpt_Timesheet]
@FromDate date = null,
@ToDate date = null
AS
BEGIN

select

T.EmployeeID,
CONVERT(date,T.LogDate) AS LogDate,
T.DayLogin,
T.DayLogout,
T.LunchLogin,
T.LunchLogout,
dbo.AMS_GetHours(T.DayMins) as DayMins,
dbo.AMS_GetHours(T.LunchMins) as LunchMins,
dbo.AMS_GetHours(T.BreakMins) as BreakMins,
U.UserName,U.FullName
from AMS_TimeSheet T
INNER JOIN AMS_UserInfo U on T.EmployeeID = U.UserInfoID
WHERE CONVERT(DATE,LogDate) >= CONVERT(DATE,@FromDate)
AND CONVERT(DATE,LogDate) <= CONVERT(DATE,@ToDate)
--AND ISNULL(DayMins,0) > 600

END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Rpt_WorkplaceRatings]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Rpt_WorkplaceRatings]  
@EmployeeID int,  
@AssessmentYearID int,  
@AssessmentModeID int  
as  
begin  
  
if exists(select 1 from AMS_WorkPlaceRatingsMap  
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID  
and EmployeeID = @EmployeeID)  
begin  
  
select WPM.WorkPlaceRatingsID,WP.RatingsDescription,  
WPM.Rating from AMS_WorkPlaceRatingsMap WPM  
inner join AMS_WorkPlaceRatings WP  
on wpm.WorkPlaceRatingsID = wP.WorkPlaceRatingsID  
where WPM.AssessmentYearID = @AssessmentYearID and WPM.AssessmentModeID = @AssessmentModeID  
and WPM.EmployeeID = @EmployeeID  
  
end  
else  
begin  
  
select WorkPlaceRatingsID,RatingsDescription,  
null as Rating from AMS_WorkPlaceRatings  
  
end  
  
select    
Improvements,Appreciations,AditionalContributions,AdtionalRole  
from AMS_WorkPlaceRatingsComments   
where AssessmentYearID = @AssessmentYearID and AssessmentModeID = @AssessmentModeID  
and EmployeeID = @EmployeeID  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_ApproveCompOff]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_ApproveCompOff]        
@CompensatoryLeaveApprovalID int = 0,    
@ApprovalStatus int = 9    
as        
begin        

declare  @CompansatoryLeaveID int = 0 ,@EmployeeID int,@HRID int,@LEID int  
select @CompansatoryLeaveID = CompensatoryLeaveID from AMS_CompensatoryLeaveApproval         
where CompensatoryLeaveApprovalID = @CompensatoryLeaveApprovalID        

select @EmployeeID = EmployeeID  
from AMS_CompensatoryLeave where CompensatoryLeaveID = @CompansatoryLeaveID
  
select @HRID = HR  
from AMS_UserInfo where UserInfoID = @EmployeeID  
  
select @LEID = LeadID from AMS_CompensatoryLeaveApproval 
where CompensatoryLeaveApprovalID = @CompensatoryLeaveApprovalID
        
update AMS_CompensatoryLeaveApproval  set ApporvedDate = dbo.AMS_GetLocalDate(GETUTCDATE()),    
ApprovalStatus = @ApprovalStatus    
where CompensatoryLeaveApprovalID = @CompensatoryLeaveApprovalID        
    
if(@ApprovalStatus = 10)    
begin    
update AMS_CompensatoryLeave set LeaveStatus = 2       
where CompensatoryLeaveID = @CompansatoryLeaveID     
end    
        
if not exists (select 1 from AMS_CompensatoryLeaveApproval         
where CompensatoryLeaveID = @CompansatoryLeaveID and ISNULL(ApprovalStatus,10) = 10)        
begin        
update AMS_CompensatoryLeave set LeaveStatus = 1         
where CompensatoryLeaveID = @CompansatoryLeaveID        
end        
else if (@ApprovalStatus <> 10 and @LEID = @HRID)  
begin  
update AMS_CompensatoryLeave set LeaveStatus = 1         
where CompensatoryLeaveID = @CompansatoryLeaveID
end  
        
select @CompensatoryLeaveApprovalID        
        
end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_ApproveLeave]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_ApproveLeave]          
@LeaveApprovalID int,          
@Comments nvarchar(500),        
@ApprovalStatus int  
as          
begin          
          
DECLARE @EmployeeLeaveID int ,@EmployeeID int,@HRID int,@LEID int  
          
select @EmployeeLeaveID = EmoloyeeLeaveID    
from AMS_LeaveApproval where LeaveApprovalID = @LeaveApprovalID          
  
select @EmployeeID = EmployeeID  
from AMS_EmployeeLeave where EmployeeLeaveID = @EmployeeLeaveID  
  
select @HRID = HR  
from AMS_UserInfo where UserInfoID = @EmployeeID  
  
select @LEID = LeadID from AMS_LeaveApproval where LeaveApprovalID = @LeaveApprovalID  
          
UPDATE AMS_LeaveApproval SET ApprovalStatus = @ApprovalStatus,        
LeadComments = @Comments,          
ApprovalDate =  dbo.AMS_GetLocalDate(GETUTCDATE())    
WHERE LeaveApprovalID = @LeaveApprovalID          
        
if(@ApprovalStatus = 10)        
begin        
update AMS_EmployeeLeave set LeaveStatusID = 2 where EmployeeLeaveID = @EmployeeLeaveID        
    
declare @LeaveDays decimal(10,2),@LeaveTypeID Int    
Select @LeaveDays = LeaveDays,    
@LeaveTypeID = LeaveTypeID from AMS_EmployeeLeave where EmployeeLeaveID = @EmployeeLeaveID    
    
if(@LeaveTypeID = 4)    
begin    
exec AMS_Upd_CompLeavesStatus @EmployeeID,@LeaveDays,1    
end    
    
    
end        
          
IF NOT EXISTS(SELECT 1 FROM AMS_LeaveApproval WHERE EmoloyeeLeaveID = @EmployeeLeaveID and ISNULL(ApprovalStatus,10) =10)          
begin          
UPDATE AMS_EmployeeLeave SET LeaveStatusID = 1 WHERE EmployeeLeaveID = @EmployeeLeaveID          
end  
else if (@ApprovalStatus <> 10 and @LEID = @HRID)  
begin  
UPDATE AMS_EmployeeLeave SET LeaveStatusID = 1 WHERE EmployeeLeaveID = @EmployeeLeaveID  
end  
          
SELECT @LeaveApprovalID          
          
end 
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompLeavesStatus]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_CompLeavesStatus]    
@EmployeeID int,    
@LeaveDays decimal(10,2),    
@IsCancel bit = 0,
@Fromdate date
as    
begin    
declare @CompensatoryLeaveID int,@CompOffDays Decimal(10,2),  
@BalDays decimal(10,2),@IsContinue bit = 1      
if(@IsCancel = 0)    
begin    
 SELECT Top(1) @CompensatoryLeaveID = CompensatoryLeaveID ,@CompOffDays = leavedays-AvailedDays      
 FROM AMS_CompensatoryLeave WHERE EmployeeID = @EmployeeID AND         
 (LeaveStatus = 1 OR LeaveStatus = 7) order by LeaveDate ASC        
 Set @BalDays = @LeaveDays - @CompOffDays        
 While(@IsContinue = 1)      
 begin      
  if(@BalDays = 0)      
  begin      
   UPDATE AMS_CompensatoryLeave SET AvailedDays = leavedays,LeaveStatus = 4 ,
   Availeddate = ISNULL(Availeddate + ',','') + CAST(@Fromdate As nvarchar(20))
   WHERE CompensatoryLeaveID = @CompensatoryLeaveID      
   SET @IsContinue = 0      
  end      
  else if(@BalDays < 0)      
  begin      
   UPDATE AMS_CompensatoryLeave SET AvailedDays = 0.5,LeaveStatus = 7,
   Availeddate = ISNULL(Availeddate + ',','') + CAST(@Fromdate As nvarchar(20))
   WHERE CompensatoryLeaveID = @CompensatoryLeaveID      
   SET @IsContinue = 0      
  end      
  ELSE      
  begin      
   UPDATE AMS_CompensatoryLeave SET AvailedDays = leavedays,LeaveStatus = 4,
   Availeddate = ISNULL(Availeddate + ',','') + CAST(@Fromdate As nvarchar(20))
   WHERE CompensatoryLeaveID = @CompensatoryLeaveID      
   SET @IsContinue = 1      
   SET @LeaveDays = @BalDays      
  end      
  SELECT Top(1) @CompensatoryLeaveID = CompensatoryLeaveID ,@CompOffDays = leavedays-AvailedDays      
  FROM AMS_CompensatoryLeave WHERE EmployeeID = @EmployeeID AND      
  (LeaveStatus = 1 OR LeaveStatus = 7) order by LeaveDate ASC        
  Set @BalDays = @LeaveDays - @CompOffDays    
 end      
 end   
 else  
 begin

 SELECT Top(1) @CompensatoryLeaveID = CompensatoryLeaveID ,@CompOffDays = AvailedDays  
 FROM AMS_CompensatoryLeave WHERE EmployeeID = @EmployeeID AND  
 (LeaveStatus = 4 OR LeaveStatus = 7) order by LeaveDate DESC  
 
 set @BalDays = @LeaveDays - @CompOffDays  
  
 While(@IsContinue = 1)      
 begin      
  if(@BalDays = 0)      
  begin      
   UPDATE AMS_CompensatoryLeave SET AvailedDays = 0,LeaveStatus = 1,
   Availeddate = null
   WHERE CompensatoryLeaveID = @CompensatoryLeaveID  
   SET @IsContinue = 0      
  end      
  else if(@BalDays < 0)      
  begin
   UPDATE AMS_CompensatoryLeave SET AvailedDays = 0.5,LeaveStatus = 7      
   WHERE CompensatoryLeaveID = @CompensatoryLeaveID  
   SET @IsContinue = 0      
  end      
  ELSE      
  begin      
   UPDATE AMS_CompensatoryLeave SET AvailedDays = 0,LeaveStatus = 1,
   Availeddate = null
   WHERE CompensatoryLeaveID = @CompensatoryLeaveID  
   SET @IsContinue = 1      
   SET @LeaveDays = @BalDays  
  end      
  SELECT Top(1) @CompensatoryLeaveID = CompensatoryLeaveID ,@CompOffDays = AvailedDays  
 FROM AMS_CompensatoryLeave WHERE EmployeeID = @EmployeeID AND  
 (LeaveStatus = 4 OR LeaveStatus = 7) order by LeaveDate DESC  
  set @BalDays = @LeaveDays - @CompOffDays  
 end  
  
 end  
 end  
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompleteQA]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_CompleteQA]  
@ProjectPhaseID int,  
@DevBuildID int,  
@QAComments nvarchar(2000),
@UserID int
  
as  
begin  

DECLARE @DevBuildLogID int    

update AMS_DevBuild set QAComments = @QAComments,  
BuildStatus= 3  
where DevBuildID = @DevBuildID  

INSERT INTO AMS_DevBuildLog(DevBuildID,LogCreatedBy,LogCreatedDate,LogType)  
VALUES(@DevBuildID,@UserID,GETDATE(),17)  
  
set @DevBuildLogID =  SCOPE_IDENTITY()  
  
insert into AMS_DevlogDescription(DevBuildLogID,BuildVersion,BuildPath,  
BuildChanges,ImpactAnalysis,ImpactModules,BuildStatus)  
select @DevBuildLogID,BuildVersion,BuildPath,BuildChanges,  
ImpactAnalysis,ImpactModules,3 from AMS_DevBuild where DevBuildID = @DevBuildID

exec AMS_Get_DevBuildForQA @ProjectPhaseID  
  
select @DevBuildID  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompOffCancelation]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  PROCEDURE [dbo].[AMS_Upd_CompOffCancelation]
@CompensatoryLeaveID int
as
begin

update AMS_CompensatoryLeave set LeaveStatus = 6
where CompensatoryLeaveID = @CompensatoryLeaveID
select @CompensatoryLeaveID

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_CompOffStatus]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_CompOffStatus]
@CompensatoryLeaveID INT,
@ChangeStatusComments nvarchar(4000)
AS
BEGIN

UPDATE AMS_CompensatoryLeave SET LeaveStatus = 1,
StatusChangeComments = @ChangeStatusComments
WHERE CompensatoryLeaveID = @CompensatoryLeaveID
select @CompensatoryLeaveID


END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_LeaveCancelation]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_LeaveCancelation]  
@EmployeeLeaveID int  
AS  
BEGIN  

declare @EmployeeID int,@LeaveDays decimal(10,2),@LeaveTypeID Int
Select @EmployeeID = EmployeeID,
@LeaveDays = LeaveDays,
@LeaveTypeID = LeaveTypeID from AMS_EmployeeLeave where EmployeeLeaveID = @EmployeeLeaveID

UPDATE AMS_EmployeeLeave SET LeaveStatusID = 6  
WHERE EmployeeLeaveID = @EmployeeLeaveID  
SELECT @EmployeeLeaveID 

if(@LeaveTypeID = 4)
begin
exec AMS_Upd_CompLeavesStatus @EmployeeID,@LeaveDays,1
end
  
END
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_Password]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_Password]  
@UserInfoID INT,  
@Password nvarchar(500)  
as  
begin  
  
update AMS_UserInfo set Passwordstring = @Password ,
IsOTP = 0
where UserInfoID = @UserInfoID  
  
SELECT                              
U.UserInfoID,                              
U.UserName,                              
U.FullName,                              
U.Passwordstring,            
U.DesignationID,            
U.ReportingLeadID,            
D.DesignationName,            
RL.FullName AS ReportingLead,    
U.RoleID    
FROM AMS_UserInfo U         
INNER JOIN AMS_Role R on U.RoleID = r.RoleID        
INNER JOIN AMS_Designation D on U.DesignationID = D.DesignationID            
left JOIN AMS_UserInfo RL on U.ReportingLeadID = RL.UserInfoID            
WHERE U.UserInfoID = @UserInfoID  
  
end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_Testcase]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_Testcase]  
@TestExecutionID int,  
@Testdata nvarchar(500),  
@TestStatus bit = null,  
@Comments nvarchar(2000),  
@UserID int  
as  
begin  
  
update AMS_TestExecution set Testdata = @Testdata,  
TestStatus = @TestStatus,  
Comments = @Comments,  
Testedby = @UserID,  
Testdate = GETDATE()  
where TestExecutionID = @TestExecutionID  
  
select @TestExecutionID

INSERT INTO AMS_TestExecutionLog(TestExecutionID,TestStatus,Comments,Testdata,Testdate,Testedby)
VALUES(@TestExecutionID,@TestStatus,@Comments,@Testdata,GETDATE(),@UserID)

end
GO
/****** Object:  StoredProcedure [dbo].[AMS_Upd_TimesheetDetails]    Script Date: 06-04-2021 15:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AMS_Upd_TimesheetDetails]          
@TimesheetID int,          
@Daylogin datetime = null,          
@Daylogout datetime = null,          
@LunchLogin datetime = null,          
@LunchLogout datetime = null,          
@dtBreaks AMS_dtBreaks readonly          
as          
begin          
          
declare @EmployeeID int = 0,@LunchMins int = 0  
set @LunchMins = DATEDIFF(MINUTE,@LunchLogin,@LunchLogout)
if(@LunchMins < 30)  
set @LunchMins = 30  
          
select @EmployeeID = EmployeeID from AMS_TimeSheet where TimesheetID = @TimesheetID          
          
UPDATE AMS_TimeSheet SET DayLogin = @Daylogin,
DayLogout = @Daylogout,          
LunchLogin = @LunchLogin,          
LunchLogout = @LunchLogout,          
LunchMins = @LunchMins  
where TimesheetID = @TimesheetID          
          
update D set D.BreakLogin = D1.BreakLogin,
D.BreakLogout = D1.BreakLogout,
BreakMins = DATEDIFF(MINUTE,D1.BreakLogin,D1.BreakLogout)
from AMS_DayBreak D inner join @dtBreaks D1          
on D.DayBreakID = D1.DayBreakID          
          
declare @BreakMins int = 0          
select @BreakMins = SUM(BreakMins) from AMS_DayBreak where TimesheetID = @TimesheetID          
          
update AMS_TimeSheet           
set DayMins = DATEDIFF(MINUTE,DayLogin,DayLogout) - ISNULL(LunchMins,0) - ISNULL(@BreakMins,0),
BreakMins = @BreakMins
where TimesheetID = @TimesheetID          
          
select @TimesheetID          
          
end 
GO
SET IDENTITY_INSERT [dbo].[AMS_AssessmentMode] ON 
GO
INSERT [dbo].[AMS_AssessmentMode] ([AssessmentModeID], [AssessmentModeName]) VALUES (1, N'Mid Year Assessment')
GO
INSERT [dbo].[AMS_AssessmentMode] ([AssessmentModeID], [AssessmentModeName]) VALUES (2, N'Anual Assessment')
GO
SET IDENTITY_INSERT [dbo].[AMS_AssessmentMode] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_AssessmentYear] ON 
GO
INSERT [dbo].[AMS_AssessmentYear] ([AssessmentYearID], [AssessmentYearName]) VALUES (1, N'2019-2020')
GO
INSERT [dbo].[AMS_AssessmentYear] ([AssessmentYearID], [AssessmentYearName]) VALUES (2, N'2020-2021')
GO
INSERT [dbo].[AMS_AssessmentYear] ([AssessmentYearID], [AssessmentYearName]) VALUES (3, N'2021-2022')
GO
SET IDENTITY_INSERT [dbo].[AMS_AssessmentYear] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_Criteria] ON 
GO
INSERT [dbo].[AMS_Criteria] ([CriteriaID], [Description], [CriteriaName]) VALUES (1, N'No quality issues after delivery to client
High Performance of developed application
Implementation of innovative technical approach
Excellent User Comfort: Intuititive Use of Tool possible
Ability to work independently', N'Knowhow & Quality')
GO
INSERT [dbo].[AMS_Criteria] ([CriteriaID], [Description], [CriteriaName]) VALUES (2, N'Completion of project within defined deadline
Completion of project within effort estimate [mandays]', N'Timely Delivery')
GO
INSERT [dbo].[AMS_Criteria] ([CriteriaID], [Description], [CriteriaName]) VALUES (3, N'High reliability
Proactive search for best approach to meet requirements', N'Commitment')
GO
SET IDENTITY_INSERT [dbo].[AMS_Criteria] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_Designation] ON 
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (1, N'Director')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (2, N'Director - Public Relations')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (3, N'Team Lead Customer Relations & Business Analytics')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (4, N' Head of Technology')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (5, N'Module Lead')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (6, N'Lead Web Developer')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (7, N'HR and Admin Associate')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (8, N'Senior Software Developer [L2]')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (9, N'Senior Software Developer [L1]')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (10, N'Software Developer [L1]')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (11, N'Testing Engineer [L1]')
GO
INSERT [dbo].[AMS_Designation] ([DesignationID], [DesignationName]) VALUES (12, N'Junior Testing Engineer')
GO
SET IDENTITY_INSERT [dbo].[AMS_Designation] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_FYear] ON 
GO
INSERT [dbo].[AMS_FYear] ([FYearID], [FYearName], [FromDate], [ToDate], [EnableAssessment]) VALUES (1, N'2018-2019', CAST(N'2018-04-01' AS Date), CAST(N'2019-03-01' AS Date), 0)
GO
INSERT [dbo].[AMS_FYear] ([FYearID], [FYearName], [FromDate], [ToDate], [EnableAssessment]) VALUES (2, N'2019-2020', CAST(N'2019-04-01' AS Date), CAST(N'2020-03-01' AS Date), 0)
GO
INSERT [dbo].[AMS_FYear] ([FYearID], [FYearName], [FromDate], [ToDate], [EnableAssessment]) VALUES (3, N'2020-2021', CAST(N'2020-04-01' AS Date), CAST(N'2021-03-31' AS Date), 0)
GO
INSERT [dbo].[AMS_FYear] ([FYearID], [FYearName], [FromDate], [ToDate], [EnableAssessment]) VALUES (4, N'2021-2022', CAST(N'2021-04-01' AS Date), CAST(N'2022-03-31' AS Date), 1)
GO
INSERT [dbo].[AMS_FYear] ([FYearID], [FYearName], [FromDate], [ToDate], [EnableAssessment]) VALUES (5, N'2022-2023', CAST(N'2022-04-01' AS Date), CAST(N'2023-03-01' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[AMS_FYear] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_GeneralPerformance] ON 
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (3, N'Innovation 
Willingness to know & learn', N'Seeking exposure to challenging projects,
Motivation to adopt new knowledge / technologies,
Receptive Attitude to Feedback from Team Leader(s)
Passion for excellence', 1, 1)
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (4, N'Prep. for Meetings  or  Calls', N'Preparation of questions, doubts and findings before a  meeting,
or a call with the team or a client', 0, 1)
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (5, N'Knowledge sharing & 
Knowledge gathering', N'Proactive knowledge sharing & knowledge gathering,
Contribution of good ideas for processes or products optimization,
Team Player', 1, 1)
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (6, N'Public speaking or 
Training for others', N'Participation or pro-active initiation for classroom trainings', 1, 1)
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (7, N'Team skills &
Personal Traits
', N'Pro-active mingling with the team,
Pro-active discussions / out-of-project activities,
Attitude (self motivated, positive attitude),
Committment', 1, 1)
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (8, N'Communication Skills', N'Ability to explain issues or requirements  to team members or clients,
English language Proficiency
', 1, 1)
GO
INSERT [dbo].[AMS_GeneralPerformance] ([GeneralPerformanceID], [RatingName], [RatingDescription], [ISCRM], [IsEmployee]) VALUES (9, N'Additional knowledge
', N'For e.g. 
Finance
German
Other..............................................', 1, 0)
GO
SET IDENTITY_INSERT [dbo].[AMS_GeneralPerformance] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_HoliDay] ON 
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (2, CAST(N'2020-08-15' AS Date), N'Independance Day', 1, 6, CAST(N'2020-08-04T18:12:36.087' AS DateTime), NULL, NULL, 20201508)
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (3, CAST(N'2020-08-21' AS Date), N'GANESH CHATHURDI', 1, 6, CAST(N'2020-08-04T18:13:38.580' AS DateTime), NULL, NULL, 20202108)
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (4, CAST(N'2020-08-31' AS Date), N'ONAM', 1, 6, CAST(N'2020-08-04T18:13:50.683' AS DateTime), NULL, NULL, 20203108)
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (5, CAST(N'2021-01-01' AS Date), N'New Year', 1, 11, CAST(N'2020-12-28T12:25:02.943' AS DateTime), NULL, NULL, 20210101)
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (6, CAST(N'2021-01-14' AS Date), N'Pongal', 1, 11, CAST(N'2020-12-28T12:25:41.460' AS DateTime), NULL, NULL, 20211401)
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (7, CAST(N'2021-11-01' AS Date), N'Kannada Rajyostava', 1, 11, CAST(N'2020-12-28T12:25:58.570' AS DateTime), NULL, NULL, 20210111)
GO
INSERT [dbo].[AMS_HoliDay] ([HolidayID], [HolidayDate], [HolidayName], [CategoryID], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DayID]) VALUES (8, CAST(N'2020-12-25' AS Date), N'Cristmas', 1, 11, CAST(N'2020-12-28T17:48:12.950' AS DateTime), NULL, NULL, 20202512)
GO
SET IDENTITY_INSERT [dbo].[AMS_HoliDay] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_LeadPerformance] ON 
GO
INSERT [dbo].[AMS_LeadPerformance] ([LeadPerformanceID], [RatingName], [RatingDescription]) VALUES (1, N'Quality Mindedness
', N'Establishment of processes & roles to meet quality targets
Establishment of measures & guidelines to meet quality targets [e.g. Coding Standards, Benchmark UI Designs]')
GO
INSERT [dbo].[AMS_LeadPerformance] ([LeadPerformanceID], [RatingName], [RatingDescription]) VALUES (2, N'Growth Mindedness
', N'Contribution to development of growth strategy
Contribution to development of infrastructure for growth:  Requirement analysis & proactive Actions
Contribution to Training & Development for the team
Meeting of Recruiting Targets')
GO
INSERT [dbo].[AMS_LeadPerformance] ([LeadPerformanceID], [RatingName], [RatingDescription]) VALUES (3, N'People Management', N'Development of Skill Set to be accepted as Leader
Lead by example in terms of reliability and quality focus
Establishment of good work environment  among subordinate team members [low attrition, high commitment in the team]
Contribution to Establishment of Recruting Best-Practices to build Team of Excellence [Quality, Commitment]
Mentoring, Technical Guidance & Motivation for the team')
GO
SET IDENTITY_INSERT [dbo].[AMS_LeadPerformance] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_LeaveStatus] ON 
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (1, N'Approved')
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (2, N'Rejected')
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (3, N'Expired')
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (4, N'Availed')
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (5, N'Approval Pending')
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (6, N'Canceled')
GO
INSERT [dbo].[AMS_LeaveStatus] ([LeaveStatusID], [LeaveStatusName]) VALUES (7, N'Partially Availed')
GO
SET IDENTITY_INSERT [dbo].[AMS_LeaveStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_LeaveType] ON 
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (1, N'Paid Leave')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (2, N'Casual Leave')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (3, N'Sick Leave')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (4, N'Compensatory Leave')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (5, N'Loss Of Pay(Un Paid)')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (6, N'Maternity Leave')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (7, N'Paternity Leave')
GO
INSERT [dbo].[AMS_LeaveType] ([LeaveTypeID], [LeaveTypeName]) VALUES (8, N'Shifting Leave')
GO
SET IDENTITY_INSERT [dbo].[AMS_LeaveType] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_Lookup] ON 
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (1, N'Government Holiday', 1, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (2, N'Corporate Holiday', 1, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (3, N'1.7.6', 2, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (4, N'Planned', 3, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (5, N'UnPlanned', 3, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (6, N'Full Day', 4, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (7, N'First Half', 4, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (8, N'Second Half', 4, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (9, N'Approved', 5, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (10, N'Rejected', 5, NULL)
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (11, N'30', 6, N'Missed TaskEntry/Leave/Comp Off')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (12, N'90', 6, N'Comp Off Expiry Days')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (13, N'02:52 PM', 7, N'Job run Time')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (14, N'1', 6, N'LeaveBalance Mail Send DAte')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (15, N'narendar.reddy@solutiontogo.de,madhukar.sreeramoju@solutiontogo.de', 7, N'AMS Server Status Mail')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (16, N'Created', 8, N'Created')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (17, N'Updated', 8, N'Updated')
GO
INSERT [dbo].[AMS_Lookup] ([LookupID], [LookupValue], [MapID], [LookupDescription]) VALUES (18, N'Deleted', 8, N'Deleted')
GO
SET IDENTITY_INSERT [dbo].[AMS_Lookup] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_Projects] ON 
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (1, N'ALSO GMBH12145', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (2, N'AUDIO CITY GUIDE APP', 2, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (3, N'AUTOHAUSdsadfsafee2342r42fsdafafdsfare', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (4, N'AZURE CONNECTOR
', 10, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (5, N'BERGMANN
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (6, N'BERLINCHEMIEAG
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (7, N'BETA - WEB HELP DESK
fdsarefk;lkf;'';fdlsafa', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (8, N'BETA AIM
', 9, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (9, N'BETA DCI
', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (10, N'BETA SCIM
', 10, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (11, N'BETA SYSTEMS - CLOUD BROKERS
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (12, N'BETA SYSTEMS (PLANNING)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (13, N'BETA SYSTEMS (SALES REPORTING)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (14, N'BETA_FINANCETOOLS_KOSTENSTELLENREPORTING
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (15, N'BETA-SERVICENOW
', 10, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (16, N'BETASYSTEM BETA 88RDF
', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (17, N'BIRMES
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (18, N'CARILONS
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (19, N'CARL ZEISS
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (20, N'CELONIC
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (21, N'CHT STRATEGISPLANUNG
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (22, N'COMPASS MOVERS
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (23, N'CONTROLLINGTOGO
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (24, N'CYBERARK
', 10, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (25, N'DASHBOARD AND REPORTING FOR JOHANNITER UNFALL HILFE
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (26, N'DASHCER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (27, N'DERMATOLOGIKUM PLANNING
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (28, N'DOOSAN
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (29, N'DOPPSTADT MESSDATENAUSWERTUNG
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (30, N'DORNIER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (31, N'DORNIER (PPT TOOLBAR)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (32, N'EXCEL TO WORD
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (33, N'EXCEL TOOL BAR
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (34, N'EXCEL TOOL CONFIGURATOR
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (35, N'EXCELTOGO WEBSITE
', 10, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (36, N'FENANCE
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (37, N'FINANCE REPORTING(BETA SYSTEMS)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (38, N'FLOWSERVE
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (39, N'FMS
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (40, N'GATEWAY
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (41, N'HABEL
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (42, N'HABEL REPORTING
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (43, N'HANSEATISCHE COFFEEBAR
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (44, N'HEAD COUNT REPORTING(BETA SYSTEMS)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (45, N'HEALER - DR.RENNER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (46, N'HELLO FRESH
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (47, N'HERAEUS PROJECT
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (48, N'HERAEUS REPORTING TOOL
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (49, N'HERAEUS SAVINGS INTIATIVE
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (50, N'HOERBIGER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (51, N'IEE
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (52, N'INTIME PLANNING
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (53, N'IWM AUTOMATION
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (54, N'KIENBAUM
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (55, N'KMC – INVOICE TOOL
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (56, N'KONEXUS PPT TOOL BAR
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (57, N'KWK
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (58, N'LBS
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (59, N'LEITNER GOOGLE DOCS
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (60, N'LIFETEC
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (61, N'MACHINE LEARNING
', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (62, N'MACRO FOR WORD AND EXCEL
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (63, N'MAIN FRAME
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (64, N'MARKETING MANAGEMENT TOOL
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (65, N'MCDONALDS
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (66, N'MIS - SCHUMACHER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (67, N'MIS (BERGMANN AUTOMOTIVE)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (68, N'MIS (DEMO)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (69, N'MIS (INTIME)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (70, N'MIS (IPR)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (71, N'MIS (LEITNER GROUP)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (72, N'MIS (MEDIFOX GROUP)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (73, N'MIS (OTTO GROUP)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (74, N'MIS (OTTO PLANNING)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (75, N'MIS (PLANNING)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (76, N'MIS DERMATOLOGIKUM
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (77, N'MIS GDVI
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (78, N'MIS PIA
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (79, N'MIS PIKETEC
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (80, N'MIS_BIOCRATES
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (81, N'MIS_KLEFFMANN
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (82, N'MIS_SIS
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (83, N'MIS-POS-DEVEXPRESS
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (84, N'OTTO CALCULATION PROJECT
', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (85, N'PORSCHE
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (86, N'POWERVIEW
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (87, N'PRECALCULATION (LEITNER GROUP)
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (88, N'PRODUCT CUSTOMER REPORTING(BETA SYSTEMS)
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (89, N'PRODUCTION INFORMATION SYSTEM (BERGMANN AUTOMOTIVE)
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (90, N'PROJECT COCKPIT (OTTO GROUP)
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (91, N'PURBI
', 6, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (92, N'QUADREX
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (93, N'REPORTINGTOGO WEBSITE
', 10, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (94, N'SALARYCALCTOOL
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (95, N'SAP SUCCESSFACTORS
', 10, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (96, N'SENSIRION AG
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (97, N'SINUS_PERSONALMANAGEMENT_MUNICH
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (98, N'SNH PPT TOOLBAR
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (99, N'SOFTWARETOGO
', 10, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (100, N'SURVEY EVALUATION
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (101, N'SWING WORKS
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (102, N'TAGGER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (103, N'TAKEDA
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (104, N'TCL 2 WEB
', 10, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (105, N'THERMOFISCHER - QSPLINE
', 7, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (106, N'THERMOFISHER
v', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (107, N'THERMOFISHER (RISKANALYSIS TOOL)
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (108, N'THERMOFISHER_RISIKOANALYSE_VARIANTERADIOBUTTON
', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (109, N'TIME MANAGEMENT APPLICATION
', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (110, N'WALTER OTTO MÜLLER
', 5, 0)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (117, N'CALCPRO', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (118, N'TEST NEW PROJECT', 6, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (119, N'TEST NEW PROJECT NEW 1', 5, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (120, N'FJLDKJSFKLJDLJLKFJKLJFA', 4, 1)
GO
INSERT [dbo].[AMS_Projects] ([ProjectID], [ProjectName], [ProjectLeadID], [IsActive]) VALUES (121, N'TESTN KFJKLDSAJFKLJDSA', 11, 1)
GO
SET IDENTITY_INSERT [dbo].[AMS_Projects] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_ProjectWorkType] ON 
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-43, N'fdfwaerdfsaffdfsfdas')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-42, N'fdfwaerdfsafhdgfdhgfh hgdfhd hgfdhgdfhgf')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-41, N'New Project Work Typ234fsfarefdsadsa')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-40, N'New Project Work Type')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-39, N'Test Dashboard Preparation
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-38, N'Writing Test Cases
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-37, N'Unit Testing
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-36, N'UI Design
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-35, N'Training
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-34, N'Testing Documentation
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-33, N'Test Planning
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-32, N'Test Executions
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-31, N'Technical Documentation
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-30, N'Tech Design
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-29, N'External Showcase Session
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-28, N'Internal Showcase Sessions
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-27, N'Research
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-26, N'Requirements Transferring
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-25, N'Requirement Analysis
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-24, N'Re-Execution
218412')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-23, N'Re-BugFixings
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-22, N'Raising Bugs
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-21, N'Project Management
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-20, N'Preparing Test Scenarios
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-19, N'Preparing Q&A
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-18, N'Preparing FPS
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-17, N'Preparing Estimates
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-16, N'Knowledge Transfer
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-15, N'Internal Support
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-14, N'Internal Call
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-13, N'Installation Softwares Related
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-12, N'End Changes to Client
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-11, N'DB Design
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-10, N'Consolidating Translations
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-9, N'Configuring Environment
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-8, N'Coding
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-7, N'Client Support
Client Support
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-6, N'Code Review
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-5, N'Client Call
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-4, N'Build Preparation
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-3, N'Bug Root Cause Analysis
 jfkd;slkf;dkafa')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-2, N'Bug Fixing
')
GO
INSERT [dbo].[AMS_ProjectWorkType] ([ProjectWorkTypeID], [WorkTypeDescription]) VALUES (-1, N'Applying Translations
')
GO
SET IDENTITY_INSERT [dbo].[AMS_ProjectWorkType] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_Role] ON 
GO
INSERT [dbo].[AMS_Role] ([RoleID], [RoleName]) VALUES (1, N'Director')
GO
INSERT [dbo].[AMS_Role] ([RoleID], [RoleName]) VALUES (3, N'Lead')
GO
INSERT [dbo].[AMS_Role] ([RoleID], [RoleName]) VALUES (4, N'Employee')
GO
INSERT [dbo].[AMS_Role] ([RoleID], [RoleName]) VALUES (6, N'HR')
GO
INSERT [dbo].[AMS_Role] ([RoleID], [RoleName]) VALUES (7, N'Head Of Technology')
GO
SET IDENTITY_INSERT [dbo].[AMS_Role] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_TechnicalPerformance] ON 
GO
INSERT [dbo].[AMS_TechnicalPerformance] ([TechnicalPerformanceID], [RatingName], [RatingDescription], [ISCRM], [ISHR], [IsEmployee]) VALUES (1, N'Technical Skills', N'Skillset to understand test requirements,
Skillset to estimate time-requirement of an application,
Skillset to test a scenario in the optimum manner,
Problem solving skills', 0, 0, 1)
GO
INSERT [dbo].[AMS_TechnicalPerformance] ([TechnicalPerformanceID], [RatingName], [RatingDescription], [ISCRM], [ISHR], [IsEmployee]) VALUES (2, N'Focus,  Ownership & 
Implementation', N'Ability to work independently,
Motivation to implement best technical solution,
Systematic Approach & timely reporting to Lead,
Dependability  & Quality Mindedness', 0, 1, 1)
GO
INSERT [dbo].[AMS_TechnicalPerformance] ([TechnicalPerformanceID], [RatingName], [RatingDescription], [ISCRM], [ISHR], [IsEmployee]) VALUES (3, N'Project Management', N'Skillset  to manage a project
Skillset to implement a customer friendly solution
Systematic Approach & timely reporting to Lead
Dependability & Quality Mindedness', 1, 0, 0)
GO
INSERT [dbo].[AMS_TechnicalPerformance] ([TechnicalPerformanceID], [RatingName], [RatingDescription], [ISCRM], [ISHR], [IsEmployee]) VALUES (4, N'Customer Management', N'Ability to work independently with Clients', 1, 0, 0)
GO
INSERT [dbo].[AMS_TechnicalPerformance] ([TechnicalPerformanceID], [RatingName], [RatingDescription], [ISCRM], [ISHR], [IsEmployee]) VALUES (5, N'Skillset and Capabilities administration', N'Skillset to understand & prioritize the days‘ requirements,
Skillset to manage day to day activities of the firm,
Skillset to act in the optimum way for the benefit of the company; welfare of the employees & the management,
Accuracy and eye for detail', 0, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[AMS_TechnicalPerformance] OFF
GO
SET IDENTITY_INSERT [dbo].[AMS_UserInfo] ON 
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (2, NULL, NULL, N'STG00', N'EuzC0mpVcoLtL+gA4+PTyw==', N'SEBASTIAN ZANG', N'+1234567890', N'sebastian.zang@betasystems.com', 1, CAST(N'2020-05-06T05:50:42.767' AS DateTime), 1, 1, 3, 0, 0, CAST(N'2011-08-19' AS Date), CAST(N'2020-08-19' AS Date), 3, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (3, NULL, NULL, N'STG01', N'EuzC0mpVcoLtL+gA4+PTyw==', N'THERESA MOOZHIYIL', N'+919980514218', N'theresa.moozhiyil@betasystems.com', 1, CAST(N'2020-05-06T05:50:42.767' AS DateTime), 1, 1, 2, 0, 1, CAST(N'2011-08-19' AS Date), CAST(N'2020-08-19' AS Date), 3, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (4, NULL, NULL, N'STG02', N'EuzC0mpVcoLtL+gA4+PTyw==', N'CHRISTOPH MATHEW MOOZHIYIL', N'0049 1639884984', N'cris.moozhi@gmail.com', 1, CAST(N'2020-05-06T05:52:13.240' AS DateTime), 1, 2, 3, 0, 0, CAST(N'2011-08-19' AS Date), CAST(N'2020-08-19' AS Date), 3, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (5, NULL, NULL, N'STG04', N'EuzC0mpVcoLtL+gA4+PTyw==', N'VIPUL SWAROOP', N'+919036212484', N'vipul.swaroop@betasystems.com', 1, CAST(N'2020-05-06T05:52:40.120' AS DateTime), 3, 17, 2, 0, 0, CAST(N'2013-01-16' AS Date), CAST(N'2020-11-16' AS Date), 3, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (6, NULL, NULL, N'STG05', N'EuzC0mpVcoLtL+gA4+PTyw==', N'MADHUKAR SREERAMOJU', N'+918106294776', N'madhukar.sreeramoju@betasystems.com', 1, CAST(N'2020-05-06T05:53:09.823' AS DateTime), 7, 4, 2, 0, 0, CAST(N'2013-06-17' AS Date), CAST(N'2020-09-04' AS Date), 1, 1, 1, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (7, NULL, NULL, N'STG06', N'EuzC0mpVcoLtL+gA4+PTyw==', N'MIRYALA JAGADEESH', N'+918095060869', N'jagadeesh.miryala@betasystems.com', 1, CAST(N'2020-05-06T05:53:37.533' AS DateTime), 4, 13, 5, 0, 0, CAST(N'2013-07-22' AS Date), CAST(N'2020-12-21' AS Date), 1, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (8, NULL, NULL, N'STG09', N'EuzC0mpVcoLtL+gA4+PTyw==', N'PREETHI G A', N'+919844538960', N'preethi.gotaparthi@betasystems.com', 1, CAST(N'2020-05-06T05:54:14.183' AS DateTime), 4, 21, 9, 0, 1, CAST(N'2014-04-29' AS Date), CAST(N'2020-01-18' AS Date), 2, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (9, NULL, NULL, N'STG10', N'EuzC0mpVcoLtL+gA4+PTyw==', N'PRASAD NR', N'+919886354692', N'prasad.renuka@betasystems.com', 1, CAST(N'2020-05-06T05:54:38.960' AS DateTime), 3, 19, 6, 0, 0, CAST(N'2014-10-13' AS Date), CAST(N'2020-08-01' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (10, NULL, NULL, N'STG11', N'EuzC0mpVcoLtL+gA4+PTyw==', N'MOHANRAJ P M', N'+919663552023', N'mohanraj.muthusamy@betasystems.com', 1, CAST(N'2020-05-06T05:54:58.783' AS DateTime), 3, 20, 6, 0, 0, CAST(N'2014-12-01' AS Date), CAST(N'2020-09-07' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (11, NULL, NULL, N'STG15', N'EuzC0mpVcoLtL+gA4+PTyw==', N'L NARENDAR REDDY', N'+917729090986', N'narendar.reddy@betasystems.com', 1, CAST(N'2020-05-06T05:55:21.087' AS DateTime), 4, 8, 6, 0, 0, CAST(N'2016-08-01' AS Date), CAST(N'2020-12-31' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (12, NULL, NULL, N'STG19', N'EuzC0mpVcoLtL+gA4+PTyw==', N'PRAVEENA ANIL MENON', N'+919740618513', N'praveena.menon@betasystems.com', 1, CAST(N'2020-05-06T05:55:53.367' AS DateTime), 4, 9, 9, 0, 1, CAST(N'2017-01-23' AS Date), CAST(N'2020-03-21' AS Date), 1, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (13, NULL, NULL, N'STG20', N'EuzC0mpVcoLtL+gA4+PTyw==', N'NAGALAKSHMI VEMULAPALLI', N'+919620272462', N'nagalakshmi.vemulapalli@betasystems.com', 1, CAST(N'2020-05-06T05:56:15.510' AS DateTime), 4, 9, 6, 0, 1, CAST(N'2017-02-02' AS Date), CAST(N'2020-03-04' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (14, NULL, NULL, N'STG22', N'EuzC0mpVcoLtL+gA4+PTyw==', N'JAISHREE SHANKARRAO LADOLE', N'+919513215737', N'jaishree.aswar@betasystems.com', 1, CAST(N'2020-05-06T05:56:37.053' AS DateTime), 4, 12, 9, 0, 1, CAST(N'2017-08-29' AS Date), CAST(N'2020-01-16' AS Date), 2, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (15, NULL, NULL, N'STG24', N'EuzC0mpVcoLtL+gA4+PTyw==', N'SUJAYA MENON', N'+919342401987', N'sujaya.menon@betasystems.com', 1, CAST(N'2020-05-06T05:56:59.127' AS DateTime), 6, 18, 3, 0, 1, CAST(N'2017-10-09' AS Date), CAST(N'2020-10-01' AS Date), 4, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (16, NULL, NULL, N'STG25', N'EuzC0mpVcoLtL+gA4+PTyw==', N'MAMIDIPALLY CHAKRADHAR', N'+917382265551', N'chakradhar.mamidipally@betasystems.com', 1, CAST(N'2020-05-06T05:57:20.407' AS DateTime), 4, 9, 6, 0, 0, CAST(N'2017-10-11' AS Date), CAST(N'2020-08-12' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (17, NULL, NULL, N'STG26', N'EuzC0mpVcoLtL+gA4+PTyw==', N'NEERAJ KUMAR K H', N'+919108732317', N'neeraj.kumar@betasystems.com', 1, CAST(N'2020-05-06T05:57:45.150' AS DateTime), 4, 11, 9, 0, 0, CAST(N'2018-03-15' AS Date), CAST(N'2020-03-07' AS Date), 2, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (18, NULL, NULL, N'STG27', N'EuzC0mpVcoLtL+gA4+PTyw==', N'RAMYA R', N'+918121910928', N'ramya.ranganath@betasystems.com', 1, CAST(N'2020-05-06T05:58:14.727' AS DateTime), 4, 12, 9, 0, 1, CAST(N'2019-05-21' AS Date), CAST(N'2020-04-08' AS Date), 2, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (19, NULL, NULL, N'STG28', N'EuzC0mpVcoLtL+gA4+PTyw==', N'JAYAPRAKASH P G', N'+919900407745', N'jayaprakash.govinda@betasystems.com', 1, CAST(N'2020-05-06T05:58:39.903' AS DateTime), 4, 13, 5, 0, 0, CAST(N'2018-06-11' AS Date), CAST(N'2020-12-15' AS Date), 1, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (20, NULL, NULL, N'STG29', N'EuzC0mpVcoLtL+gA4+PTyw==', N'ANEESHA DEVI', N'+917760362187', N'aneesha.devi@betasystems.com', 1, CAST(N'2020-05-06T05:59:02.070' AS DateTime), 4, 12, 9, 0, 1, CAST(N'2018-07-18' AS Date), CAST(N'2020-06-19' AS Date), 2, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (21, NULL, NULL, N'STG30', N'EuzC0mpVcoLtL+gA4+PTyw==', N'PRACHI SAHU', N'+918319458313', N'prachi.sahu@betasystems.com', 1, CAST(N'2020-05-06T05:59:29.990' AS DateTime), 4, 12, 9, 0, 1, CAST(N'2018-07-18' AS Date), CAST(N'2020-11-25' AS Date), 2, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (22, NULL, NULL, N'STG35', N'EuzC0mpVcoLtL+gA4+PTyw==', N'MITHUN M', N'+919611608013', N'mithun.murali@betasystems.com', 1, CAST(N'2020-05-06T05:59:56.013' AS DateTime), 4, 13, 10, 0, 0, CAST(N'2019-04-09' AS Date), CAST(N'2020-07-23' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (23, NULL, NULL, N'STG36', N'EuzC0mpVcoLtL+gA4+PTyw==', N'SUSHMA M GOWDA', N'+9174114 34843', N'sushma.mgowda@betasystems.com', 1, CAST(N'2020-05-06T06:00:23.540' AS DateTime), 4, 12, 9, 0, 1, CAST(N'2019-10-21' AS Date), CAST(N'2020-08-18' AS Date), 2, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (24, NULL, NULL, N'STG39', N'EuzC0mpVcoLtL+gA4+PTyw==', N'MAZHAR AHMED', N'+919738581286', N'mazhar.ahmed@betasystems.com', 1, CAST(N'2020-05-06T06:00:56.877' AS DateTime), 4, 12, 9, 0, 0, CAST(N'2019-12-30' AS Date), CAST(N'2020-05-02' AS Date), 2, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (25, NULL, NULL, N'STG40', N'EuzC0mpVcoLtL+gA4+PTyw==', N'GARGI SARKAR', N'+919051172479', N'gargi.sarkar@betasystems.com', 1, CAST(N'2020-05-06T06:01:21.317' AS DateTime), 4, 10, 10, 0, 1, CAST(N'2019-01-10' AS Date), CAST(N'2020-02-21' AS Date), 1, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (26, NULL, NULL, N'STG42', N'EuzC0mpVcoLtL+gA4+PTyw==', N'GANESHAN PALANI', N'+919600414168', N'ganeshan.palani@betasystems.com', 1, CAST(N'2020-05-06T06:01:53.150' AS DateTime), 4, 10, 10, 0, 0, CAST(N'2020-03-16' AS Date), CAST(N'2020-05-25' AS Date), 1, 0, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (27, NULL, NULL, N'STG43', N'EuzC0mpVcoLtL+gA4+PTyw==', N'ANILET ANTONY', N'9947110599', N'anilet.vantony@betasystems.com', 1, CAST(N'2020-06-28T05:46:33.607' AS DateTime), 4, 10, 6, 0, 1, CAST(N'2020-07-06' AS Date), CAST(N'2020-01-03' AS Date), 1, 1, 0, 15)
GO
INSERT [dbo].[AMS_UserInfo] ([UserInfoID], [OrgID], [BranchID], [UserName], [Passwordstring], [FullName], [CNumber], [EMail], [CreatedBy], [CreatedDate], [RoleID], [DesignationID], [ReportingLeadID], [IsOTP], [Gender], [JoingDate], [DOB], [DepatmentID], [EmployeeStatus], [EnableAssessmnet], [HR]) VALUES (28, NULL, NULL, N'STG44', N'EuzC0mpVcoLtL+gA4+PTyw==', N'ABHISHEK PANDEY', N'9620491774', N'abhishek.pandey@betasystems.com', 1, CAST(N'2021-03-10T11:35:28.727' AS DateTime), 4, 8, 6, 0, 0, CAST(N'2021-03-10' AS Date), CAST(N'1982-08-09' AS Date), 1, 1, 0, 15)
GO
SET IDENTITY_INSERT [dbo].[AMS_UserInfo] OFF
GO