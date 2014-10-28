using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FluentPro.FluentPS.Contracts.Model.Enums
{
    [Serializable]
    [XmlType(Namespace = "http://schemas.microsoft.com/office/project/server/webservices/Project/")]
    public enum PSErrorID
    {
        NoError,
        Success,
        ActiveCacheInvalidDataFormat,
        ActiveCacheUnsupportedDataFormatVersion,
        ActiveCacheInvalidQueuedMessageType,
        ActiveCacheNullQueuedMessage,
        ActiveCacheQueuedMessageExecutionError,
        ActiveCacheInvalidDataSize,
        ActiveCacheQueueJobAlreadyStarted,
        ActiveCacheInvalidQueuedMessageFormat,
        ActiveCacheUnsupportedQueuedMessageVersion,
        ActiveCacheUnsupportedQueueDataType,
        ActiveCacheInvalidVersionStampForSave,
        ActiveCacheProjectTypeMismatch,
        ActiveCacheDataValidationFailed,
        ActiveCacheUnsupportedProjectProfessionalVersion,
        ActiveCacheGeneralSQLException,
        ActiveCacheIncompleteJobSendCanceled,
        AdminViewNameAlreadyExists,
        AdminViewInvalidDividerPosition,
        AdminViewDataWasTampered,
        AdminViewMaxDisplayedFieldsNumberExceeded,
        AdminViewCannotDeleteDefaultView,
        AdminViewCannotCopyDefaultView,
        AdminLocalCustomFieldInvalid,
        AdminEnterpriseCustomFieldInvalid,
        AdminNTAccountNotFound,
        AdminUnableToMerge,
        AdminDeleteArchivedProjectsFailed,
        AdminUpdateArchiveScheduleFailed,
        AdminArchiveScheduleFailed,
        AdminReadArchivedProjectsListFailed,
        AdminReadArchiveScheduleFailed,
        AdminUserAccountNameNull,
        AdminIsWindowsUserNull,
        AdminInvalidTimePeriodState,
        AdminGlobalUpdateFailed,
        AdminGlobalCheckedOut,
        AdminInvalidDatabaseTimeout,
        AdminInvalidDatabaseTimeoutType,
        AdminInvalidEntityType,
        AdminInvalidCompatibilityModeChange,
        AdminInvalidCompatibilityMode,
        AdminInvalidProjectProfessionalVersions,
        AdminInvalidProjectProfessionalVersion,
        AdminTooManyProjectProfessionalVersions,
        AdminDuplicateProjectProfessionalMajorVersions,
        AdminInvalidServerFlags,
        AdminNullProjectProfessionalVersions,
        ArchiveProjectFailure,
        ArchiveProjectsFailed,
        ArchiveProjectFailed,
        ArchiveResourcesFailed,
        ArchiveCustomFieldsFailed,
        ArchiveSystemSettingsFailed,

        /// <remarks/>
        ArchiveCategoriesFailed,

        /// <remarks/>
        ArchiveViewsFailed,

        /// <remarks/>
        ArchiveGlobalProjectFailed,

        /// <remarks/>
        ArchiveReadProjectArchiveRetentionSettingFailed,

        /// <remarks/>
        ArchiveInvalidRetentionPolicyValue,

        /// <remarks/>
        ArchiveCustomFieldsFailure,

        /// <remarks/>
        ArchiveGlobalProjectFailure,

        /// <remarks/>
        ArchiveResourcesFailure,

        /// <remarks/>
        ArchiveSystemSettingsFailure,

        /// <remarks/>
        ArchiveViewsFailure,

        /// <remarks/>
        ArchiveCategoriesFailure,

        /// <remarks/>
        ResourcePlanPublishFailure,

        /// <remarks/>
        RestoreCategoriesFailure,

        /// <remarks/>
        RestoreCustomFieldsFailure,

        /// <remarks/>
        RestoreGlobalProjectFailure,

        /// <remarks/>
        RestoreProjectFailure,

        /// <remarks/>
        RestoreResourcesFailure,

        /// <remarks/>
        RestoreSystemSettingsFailure,

        /// <remarks/>
        RestoreViewsFailure,

        /// <remarks/>
        AssignmentNotFound,

        /// <remarks/>
        AssignmentWrongTrackingMethod,

        /// <remarks/>
        AssignmentWorkTypeInvalid,

        /// <remarks/>
        AssignmentRateTableInvalid,

        /// <remarks/>
        AssignmentAlreadyExists,

        /// <remarks/>
        AssignmentDuplicateSpecified,

        /// <remarks/>
        AssignmentUidInvalid,

        /// <remarks/>
        AssignmentDelayInvalid,

        /// <remarks/>
        AssignmentCannotEditSummaryTask,

        /// <remarks/>
        AssignmentInvalid,

        /// <remarks/>
        AssignmentFieldsInvalidForBudget,

        /// <remarks/>
        AssignmentAlreadyAssignedToResource,

        /// <remarks/>
        AssignmentInvalidOwner,

        /// <remarks/>
        CalendarUidInvalid,

        /// <remarks/>
        CalendarOnlyOneShiftIsNull,

        /// <remarks/>
        CalendarRecurrenceDaysShouldBeNull,

        /// <remarks/>
        CalendarRecurrenceMonthDayShouldBeNull,

        /// <remarks/>
        CalendarRecurrenceMonthShouldBeNull,

        /// <remarks/>
        CalendarRecurrenceMonthShouldNotBeNull,

        /// <remarks/>
        CalendarRecurrencePositionShouldBeNull,

        /// <remarks/>
        CalendarRecurrencePositionShouldNotBeNull,

        /// <remarks/>
        CalendarRecurrenceDaysShouldNotBeNull,

        /// <remarks/>
        CalendarInvalidRecurrenceFrequency,

        /// <remarks/>
        CalendarInvalidRecurrenceType,

        /// <remarks/>
        CalendarInvalidRecurrenceDays,

        /// <remarks/>
        CalendarInvalidCombinationOfMonthDayAndPosition,

        /// <remarks/>
        CalendarInvalidRecurrencePosition,

        /// <remarks/>
        CalendarCannotModifyExceptionsForCalendarBeingDeleted,

        /// <remarks/>
        CalendarExceptionConflict,

        /// <remarks/>
        CalendarBadDateValue,

        /// <remarks/>
        CalendarNotFound,

        /// <remarks/>
        CalendarAlreadyExists,

        /// <remarks/>
        CalendarNameShouldNotBeNull,

        /// <remarks/>
        CalendarInternalError,

        /// <remarks/>
        CalendarNameTooLong,

        /// <remarks/>
        CalendarInvalidCalendarName,

        /// <remarks/>
        CalendarStandardCalendarNotFound,

        /// <remarks/>
        CalendarInvalidShifts,

        /// <remarks/>
        CalendarCannotDeleteCalendarUsedByProject,

        /// <remarks/>
        CalCalendarUniqueIdToDuplicateShouldBeNull,

        /// <remarks/>
        CalendarInvalidBaseCalendarUniqueId,

        /// <remarks/>
        CalendarInvalidUniqueIdToDuplicate,

        /// <remarks/>
        CalendarUnusedCalendarException,

        /// <remarks/>
        CalendarCannotDeleteStandardCalendar,

        /// <remarks/>
        CalendarCannotRenameStandardCalendar,

        /// <remarks/>
        CalendarCannotDeleteCalendarUsedByEnterpriseResource,

        /// <remarks/>
        CalendarFilterInvalid,

        /// <remarks/>
        CBSGeneralFailure,

        /// <remarks/>
        CBSDsoNotInstalled,

        /// <remarks/>
        CBSASConnectionFailure,

        /// <remarks/>
        CBSOlapProcessingFailure,

        /// <remarks/>
        CBSMetadataProcessingFailure,

        /// <remarks/>
        CBSASServerLockTimeOut,

        /// <remarks/>
        CBSOlapDatabaseSetupFailure,

        /// <remarks/>
        CBSASEntityLimitation,

        /// <remarks/>
        CBSRequestInvalidArguments,

        /// <remarks/>
        CBSQueueingRequestFailed,

        /// <remarks/>
        CBSUpdateCubeCalculatedMeasureDefintionError,

        /// <remarks/>
        CBSAttemptToOverwrite,

        /// <remarks/>
        CBSCustomFieldCannotBeAddedAsDimension,

        /// <remarks/>
        CBSCustomFieldFailedToBeAddedAsDimension,

        /// <remarks/>
        CBSCustomFieldCannotBeAddedAsMeasure,

        /// <remarks/>
        CBSCustomFieldFailedToBeAddedAsMeasure,

        /// <remarks/>
        CBSDsoTranslatorNotFound,

        /// <remarks/>
        CBSUpdateOlapDBOperationFailure,

        /// <remarks/>
        CBSOlapDBInvalidArguments,

        /// <remarks/>
        CBSOlapDatabaseReadSettingListFailed,

        /// <remarks/>
        CBSOlapDatabaseReadSettingFailed,

        /// <remarks/>
        CBSDeleteOlapDatabaseSetting,

        /// <remarks/>
        CBSSetDefaultOlapDatabase,

        /// <remarks/>
        CBSSetOlapDatabaseEnabled,

        /// <remarks/>
        CBSGetDefaultOlapDatabase,

        /// <remarks/>
        CBSCustomFieldFailedToBeAddedAsDimensionOrMeasure,

        /// <remarks/>
        CBSOlapDatabaseAssocFieldsSettings,

        /// <remarks/>
        CBSUpdateOlapDBOperationDuplicateOrFailure,

        /// <remarks/>
        CBSErrorReadingDefaultDatabase,

        /// <remarks/>
        CBSCreateOlapDBOperationFailure,

        /// <remarks/>
        CBSSetCubeFieldsSettingsFromListForGroupMeasureFailed,

        /// <remarks/>
        CBSErrorReadingCubeDepartments,

        /// <remarks/>
        CBSErrorMaxOlapDatabaseCountReached,

        /// <remarks/>
        CBSErrorReadingCubeFieldsSettings,

        /// <remarks/>
        CICOCheckedOutToOtherUser,

        /// <remarks/>
        CICOAlreadyCheckedOutToYou,

        /// <remarks/>
        CICONotCheckedOut,

        /// <remarks/>
        CICOCheckedOutInOtherSession,

        /// <remarks/>
        CICOInvalidSessionGuid,

        /// <remarks/>
        CICOAlreadyCheckedOutInSameSession,

        /// <remarks/>
        CICOCannotCheckOutVisibilityModeProjectWithMppInDocLib,

        /// <remarks/>
        CustomFieldInvalidPropertyType,

        /// <remarks/>
        CustomFieldInvalidScope,

        /// <remarks/>
        CustomFieldScopesMustBeIdentical,

        /// <remarks/>
        CustomFieldInvalidEntityUID,

        /// <remarks/>
        CustomFieldHasInvalidPropertiesForNonLookupTableCF,

        /// <remarks/>
        CustomFieldNonExistentWeightsTableUID,

        /// <remarks/>
        CustomFieldInvalidName,

        /// <remarks/>
        CustomFieldInvalidDefault,

        /// <remarks/>
        CustomFieldInvalidLookupTableUID,

        /// <remarks/>
        CustomFieldTypeDoesNotMatchLookupTableMask,

        /// <remarks/>
        CustomFieldCannotHaveNonLeafNodeDefault,

        /// <remarks/>
        CustomFieldMatchingOnlyAvailableForResources,

        /// <remarks/>
        CustomFieldUIDCannotMatchLookupTableUID,

        /// <remarks/>
        CustomFieldUIDAlreadyExists,

        /// <remarks/>
        CustomFieldIDAlreadyExists,

        /// <remarks/>
        CustomFieldNameAlreadyExists,

        /// <remarks/>
        CustomFieldInvalidEntity,

        /// <remarks/>
        CustomFieldMaskDoesNotMatchEntityType,

        /// <remarks/>
        CustomFieldLowerOrderBitsOutOfRange,

        /// <remarks/>
        CustomFieldInvalidMaxValues,

        /// <remarks/>
        CustomFieldCannotModifyCertainValuesOnceDefined,

        /// <remarks/>
        CustomFieldNonExistentPID,

        /// <remarks/>
        CustomFieldCannotChangeBuiltInFields,

        /// <remarks/>
        CustomFieldSecondaryUidCannotEqualUid,

        /// <remarks/>
        CustomFieldCannotHaveSecondaryUIDorIDForThisEntityType,

        /// <remarks/>
        CustomFieldNameMatchesIntrinsicField,

        /// <remarks/>
        CustomFieldInvalidAggregationType,

        /// <remarks/>
        CustomFieldProjectFormulaFieldsMustUseFormulaAggregation,

        /// <remarks/>
        CustomFieldMustSpecifyEitherIDorUID,

        /// <remarks/>
        CustomFieldInvalidID,

        /// <remarks/>
        CustomFieldInvalidUID,

        /// <remarks/>
        CustomFieldInvalidType,

        /// <remarks/>
        CustomFieldInvalidTypeColumnFilledIn,

        /// <remarks/>
        CustomFieldCodeValueDoesNotMatchLookupTable,

        /// <remarks/>
        CustomFieldCodeValueIsNotLeafNode,

        /// <remarks/>
        CustomFieldRowAlreadyExists,

        /// <remarks/>
        CustomFieldRowDoesNotMatchCorrespondingDefinitionInDB,

        /// <remarks/>
        CustomFieldCodeValueAlreadyUsed,

        /// <remarks/>
        CustomFieldMaxValuesExceeded,

        /// <remarks/>
        CustomFieldRequiredValueNotProvided,

        /// <remarks/>
        CustomFieldCannotChangeLookupTable,

        /// <remarks/>
        CustomFieldFilterInvalid,

        /// <remarks/>
        CustomFieldRolldownInvalidOnFormulaFields,

        /// <remarks/>
        CustomFieldFormulaFieldCannotBeRequired,

        /// <remarks/>
        CustomFieldFormulaFieldCannotBeWorkflowControlled,

        /// <remarks/>
        CustomFieldCannotSetValueOnFormulaFields,

        /// <remarks/>
        CustomFieldNewPerRequestLimitExcedeed,

        /// <remarks/>
        CustomFieldNameIsReservedName,

        /// <remarks/>
        CustomFieldNameInvalidForOlapMeasure,

        /// <remarks/>
        CustomFieldNameInvalidForOlapDimension,

        /// <remarks/>
        CustomFieldSettingsInvalidForOlapMeasure,

        /// <remarks/>
        CustomFieldSettingsInvalidForOlapDimension,

        /// <remarks/>
        CustomFieldCannotAddRelativeImportanceField,

        /// <remarks/>
        CustomFieldCannotAddProjectImpactField,

        /// <remarks/>
        CustomFieldInvalidDepartmentUid,

        /// <remarks/>
        CustomFieldCannotModifyDepartmentUidOnBuiltinFields,

        /// <remarks/>
        CustomFieldCannotHaveBothLookupTableAndMultilineText,

        /// <remarks/>
        CustomFieldCannotHaveBothFormulaAndMultilineText,

        /// <remarks/>
        CustomFieldDescriptionExceedsLimit,

        /// <remarks/>
        CustomFieldOnlyTextFieldsCanHaveMultilineText,

        /// <remarks/>
        CustomFieldOnlyProjectFieldsCanHaveMultilineText,

        /// <remarks/>
        CustomFieldCannotChangeWorkflowControlledBehaviorForNonProjectCustomFields,

        /// <remarks/>
        CustomFieldIsWorkflowControlledAndCannotBeChanged,

        /// <remarks/>
        CustomFieldCannotHaveRequiredFlagWhenWorkflowControlledFlagIsSet,

        /// <remarks/>
        CustomFieldFormulaCreatesCircularReference,

        /// <remarks/>
        CustomFieldFormulaContainsInvalidFieldReference,

        /// <remarks/>
        CustomFieldFormulaContainsErrors,

        /// <remarks/>
        CustomFieldLocalCustomFieldNotDefined,

        /// <remarks/>
        CustomFieldGraphicalIndicatorContainsErrors,

        /// <remarks/>
        CustomFieldGraphicalIndicatorContainsInvalidFieldReference,

        /// <remarks/>
        CustomFieldGraphicalIndicatorTypeMismatch,

        /// <remarks/>
        CustomFieldFormulaFieldCannotReferenceWorkflowControlledField,

        /// <remarks/>
        CustomFieldWorkflowCustomFieldBeingReferencedByFormula,

        /// <remarks/>
        GeneralRequestInvalidParameter,

        /// <remarks/>
        GeneralInvalidValue,

        /// <remarks/>
        GeneralStartDateGTorEQFinishDate,

        /// <remarks/>
        GeneralQueueOperationInProcess,

        /// <remarks/>
        GeneralUnhandledException,

        /// <remarks/>
        GeneralDuplicateGUIDSpecified,

        /// <remarks/>
        GeneralDateNotValid,

        /// <remarks/>
        GeneralCostInvalid,

        /// <remarks/>
        GeneralWorkInvalid,

        /// <remarks/>
        GeneralDurationInvalid,

        /// <remarks/>
        GeneralUnitsInvalid,

        /// <remarks/>
        GeneralOnlyInsertsAllowed,

        /// <remarks/>
        GeneralOnlyUpdatesAllowed,

        /// <remarks/>
        GeneralSessionInvalid,

        /// <remarks/>
        GeneralDependencyUidInvalid,

        /// <remarks/>
        GeneralNumberInvalid,

        /// <remarks/>
        GeneralInvalidDataStore,

        /// <remarks/>
        GeneralDurationOrWorkFormatInvalid,

        /// <remarks/>
        GeneralRateFormatInvalid,

        /// <remarks/>
        GeneralQueueException,

        /// <remarks/>
        GeneralItemDoesNotExist,

        /// <remarks/>
        GeneralLCIDInvalid,

        /// <remarks/>
        GeneralRowDoesNotExist,

        /// <remarks/>
        GeneralInvalidColumnValue,

        /// <remarks/>
        GeneralInvalidDataRowState,

        /// <remarks/>
        GeneralDuplicatedNames,

        /// <remarks/>
        GeneralReadOnlyColumn,

        /// <remarks/>
        GeneralReadOnlyRow,

        /// <remarks/>
        GeneralNotNullColumn,

        /// <remarks/>
        GeneralObjectAlreadyExists,

        /// <remarks/>
        GeneralInvalidObject,

        /// <remarks/>
        GeneralSecurityAccessDenied,

        /// <remarks/>
        GeneralInvalidOperation,

        /// <remarks/>
        GeneralInvalidCharacters,

        /// <remarks/>
        GeneralNameTooLong,

        /// <remarks/>
        GeneralNameCannotBeBlank,

        /// <remarks/>
        GeneralInvalidOperationOnReadOnlyValue,

        /// <remarks/>
        GeneralInvalidDateOverlap,

        /// <remarks/>
        GeneralParameterCannotBeNull,

        /// <remarks/>
        GeneralDescTooLong,

        /// <remarks/>
        GeneralCategoryPermissionDenied,

        /// <remarks/>
        GeneralGlobalPermissionDenied,

        /// <remarks/>
        GeneralNotLicensed,

        /// <remarks/>
        GeneralActionCanceledByEventHandler,

        /// <remarks/>
        GeneralActionCanceledBecauseServerEventServiceNotFound,

        /// <remarks/>
        GeneralActionCanceledBecauseServerEventServiceProblem,

        /// <remarks/>
        GeneralActionProceedWithServerEventServiceProblem,

        /// <remarks/>
        GeneralQueueJobFailed,

        /// <remarks/>
        GeneralQueueInvalidJobUID,

        /// <remarks/>
        GeneralQueueInvalidTrackingUID,

        /// <remarks/>
        GeneralQueueInvalidJobInfoUID,

        /// <remarks/>
        GeneralQueueInvalidCorrelationUID,

        /// <remarks/>
        GeneralQueueCorrelationBlocked,

        /// <remarks/>
        GeneralQueueInvalidMessageType,

        /// <remarks/>
        GeneralQueueInvalidJobState,

        /// <remarks/>
        GeneralQueueInvalidGroupState,

        /// <remarks/>
        GeneralQueueInvalidGroupPriority,

        /// <remarks/>
        GeneralQueueInvalidCorrelationPriority,

        /// <remarks/>
        GeneralQueueInvalidQueueID,

        /// <remarks/>
        GeneralQueueInvalidAdminAction,

        /// <remarks/>
        GeneralQueueInvalidStatType,

        /// <remarks/>
        GeneralQueueInvalidBlockPolicy,

        /// <remarks/>
        GeneralQueueCannotRetryJob,

        /// <remarks/>
        GeneralQueueInvalidSetting,

        /// <remarks/>
        GeneralQueueInvalidRendezvousUID,

        /// <remarks/>
        GeneralDalErrorGettingConnectionStrings,

        /// <remarks/>
        GeneralDalErrorConnectingToDatabase,

        /// <remarks/>
        GeneralDalInvalidArgumentCountCreatingFilter,

        /// <remarks/>
        GeneralDataTableCannotBeNull,

        /// <remarks/>
        GeneralDatasetConstraints,

        /// <remarks/>
        GeneralInvalidDataSetStructure,

        /// <remarks/>
        GeneralDalNoRowsUpdated,

        /// <remarks/>
        GeneralDataTableCannotBeEmpty,

        /// <remarks/>
        GeneralWSSContentDBNotWritable,

        /// <remarks/>
        GeneralSPValidateFormDigestError,

        /// <remarks/>
        GeneralDelegationActiveForCurrentUser,

        /// <remarks/>
        GeneralDalDatabaseIsReadOnly,

        /// <remarks/>
        GeneralDatabaseCommunicationError,

        /// <remarks/>
        LookupTableMaskNotDefined,

        /// <remarks/>
        LookupTableMaskHasTooManyValues,

        /// <remarks/>
        LookupTableMaskHasGaps,

        /// <remarks/>
        LookupTableMaskSequenceTypeLimitedToOneLevelDeep,

        /// <remarks/>
        LookupTableMaskSequenceTypeInvalid,

        /// <remarks/>
        LookupTableMaskSequenceRequiresAnyLength,

        /// <remarks/>
        LookupTableMaskSeparatorTooLong,

        /// <remarks/>
        LookupTableMaskLevelMustBeBlankAcrossLCIDs,

        /// <remarks/>
        LookupTableMaskSeparatorInvalid,

        /// <remarks/>
        LookupTableMaskBlankSeparatorInvalidAfterAnyLengthSequence,

        /// <remarks/>
        LookupTableMaskSequenceLengthInvalid,

        /// <remarks/>
        LookupTableMaskLevelMustBeOneOrMore,

        /// <remarks/>
        LookupTableItemDoesNotFitMask,

        /// <remarks/>
        LookupTableItemContainsSeparator,

        /// <remarks/>
        LookupTableItemFullValueTooLong,

        /// <remarks/>
        LookupTableDuplicateSiblingsDisallowed,

        /// <remarks/>
        LookupTableSortOrderIndexInvalid,

        /// <remarks/>
        LookupTableSortOrderIndexDuplicate,

        /// <remarks/>
        LookupTableSortOrderTypeInvalid,

        /// <remarks/>
        LookupTableSortOrderMustComeAfterParentSortOrder,

        /// <remarks/>
        LookupTableSortOrderMustComeBeforeParentNextSiblingSortOrder,

        /// <remarks/>
        LookupTableInvalidCookieLength,

        /// <remarks/>
        LookupTableMustHaveValuesForPrimaryLCIDorJustOneValue,

        /// <remarks/>
        LookupTableLCIDNotSupportedInLookupTableLanguages,

        /// <remarks/>
        LookupTableInvalidDescriptionLength,

        /// <remarks/>
        LookupTableCannotChangeBuiltInTables,

        /// <remarks/>
        LookupTableCannotChangeTypeOnceCreated,

        /// <remarks/>
        LookupTableCannotDeleteLTWithDependantCustomField,

        /// <remarks/>
        LookupTableAllLevelsNotFilled,

        /// <remarks/>
        LookupTableDuplicateName,

        /// <remarks/>
        LookupTableInvalidName,

        /// <remarks/>
        LookupTableDuplicateSiblingPhoneticsDisallowed,

        /// <remarks/>
        LookupTableItemInvalidLookupTable,

        /// <remarks/>
        LookupTableInvalidPhoneticsLength,

        /// <remarks/>
        LookupTableAlreadyExists,

        /// <remarks/>
        LookupTableInvalidUID,

        /// <remarks/>
        LookupTableFilterInvalid,

        /// <remarks/>
        LookupTableLanguageParameterInvalidWithXmlFilter,

        /// <remarks/>
        LookupTableInvalidParentStructUid,

        /// <remarks/>
        LookupTableItemContainsListSeparator,

        /// <remarks/>
        NotificationReminderUnknown,

        /// <remarks/>
        NotificationReminderParentNotSubscribed,

        /// <remarks/>
        NotificationReminderParentNotFound,

        /// <remarks/>
        NotificationReminderChildStillSubscribed,

        /// <remarks/>
        NotificationReminderChildNotFound,

        /// <remarks/>
        NotificationEMailDeliveryFailed,

        /// <remarks/>
        NotificationQueueMessageFailed,

        /// <remarks/>
        NotificationXSLTTransformationError,

        /// <remarks/>
        ProjectGlobalNotFound,

        /// <remarks/>
        ProjectGlobalCannotBeDeleted,

        /// <remarks/>
        ProjectNotFound,

        /// <remarks/>
        ProjectAlreadyExists,

        /// <remarks/>
        ProjectCheckedoutToOtherUser,

        /// <remarks/>
        ProjectTypeInvalidForCreate,

        /// <remarks/>
        ProjectParametersInvalid,

        /// <remarks/>
        ProjectNotCheckedoutToUser,

        /// <remarks/>
        ProjectCheckedout,

        /// <remarks/>
        ProjectTypeInvalid,

        /// <remarks/>
        ProjectIDInvalid,

        /// <remarks/>
        ProjectNameTooLong,

        /// <remarks/>
        ProjectManagerNameTooLong,

        /// <remarks/>
        ProjectNameInvalid,

        /// <remarks/>
        ProjectStartDateMissing,

        /// <remarks/>
        ProjectNameMissing,

        /// <remarks/>
        ProjectVersionMissing,

        /// <remarks/>
        ProjectDoesNotExist,

        /// <remarks/>
        ProjectMultipleProjectsInvalid,

        /// <remarks/>
        ProjectHasWriteLock,

        /// <remarks/>
        ProjectHasPendingWriteLock,

        /// <remarks/>
        ProjectHasNoReadLock,

        /// <remarks/>
        ProjectHasReadLock,

        /// <remarks/>
        ProjectNameAlreadyExists,

        /// <remarks/>
        ProjectOptCriticalSlackLimitInvalid,

        /// <remarks/>
        ProjectOptCurrencyPositionInvalid,

        /// <remarks/>
        ProjectOptCurrencyDigitsInvalid,

        /// <remarks/>
        ProjectOptCurrencySymbolTooLong,

        /// <remarks/>
        ProjectCannotDelete,

        /// <remarks/>
        ProjectCannotAdd,

        /// <remarks/>
        ProjectOptCurrencySymbolInvalid,

        /// <remarks/>
        ProjectHasNoWriteLock,

        /// <remarks/>
        ProjectFilterInvalid,

        /// <remarks/>
        ProjectTooLarge,

        /// <remarks/>
        ProjectOptCurrencyCodeNot3Chars,

        /// <remarks/>
        ProjectOptCurrencyCodeInvalid,

        /// <remarks/>
        ProjectActualsAreProtected,

        /// <remarks/>
        ProjectTemplateNotFound,

        /// <remarks/>
        ProjectCurrencyCodeInvalid,

        /// <remarks/>
        ProjectCannotEditCostResource,

        /// <remarks/>
        ProjectIsNotPublished,

        /// <remarks/>
        ProjectExceededLWPTaskLimit,

        /// <remarks/>
        ProjectOptFinishDateInvalid,

        /// <remarks/>
        ProjectExceededItemsLimit,

        /// <remarks/>
        ProjectColumnNotReadOnly,

        /// <remarks/>
        ProjectInvalidOwner,

        /// <remarks/>
        ProjectCantEditPctWrkCompForNonWrkRscs,

        /// <remarks/>
        ProjectCannotEditMaterialResource,

        /// <remarks/>
        ProjectCannotEditFieldWhenTaskHasNoWorkAssignment,

        /// <remarks/>
        ProjectSubProjectNotFound,

        /// <remarks/>
        ProjectResourceNotFound,

        /// <remarks/>
        ProjectResourceAlreadyExists,

        /// <remarks/>
        ProjectCannotReplaceResourceWithSelf,

        /// <remarks/>
        ProjectCannotChangeLockedTrackingMethod,

        /// <remarks/>
        ProjectInvalidColumnForCompatibilityMode,

        /// <remarks/>
        ProjectUpdateInvalidUpdateSequenceNumber,

        /// <remarks/>
        ProjectUpdateDuplicateUpdateSequenceNumber,

        /// <remarks/>
        ProjectUpdateNullUpdateSequenceNumber,

        /// <remarks/>
        ProjectUpdateNullUpdateColumnNames,

        /// <remarks/>
        ProjectUpdateInvalidProjectUID,

        /// <remarks/>
        ProjectUpdateInvalidColumnForUpdate,

        /// <remarks/>
        ProjectUpdateCannotEditColumn,

        /// <remarks/>
        ProjectUpdateNoChangesToValidateAndSchedule,

        /// <remarks/>
        LinkNotFound,

        /// <remarks/>
        ProjectUpdateInvalidColumnValue,

        /// <remarks/>
        ProjectCannotDeleteItem,

        /// <remarks/>
        ProjectUpdateCannotComputeOptIndex,

        /// <remarks/>
        ProjectCannotUpdateDueToVisibilityMode,

        /// <remarks/>
        ProjectNodeConsistencyException,

        /// <remarks/>
        ProjectSchedulingEngineException,

        /// <remarks/>
        ProjectFormulaCalculationException,

        /// <remarks/>
        ProjectUpdateDatabaseException,

        /// <remarks/>
        ProjectDeleteException,

        /// <remarks/>
        ProjectOperationException,

        /// <remarks/>
        ProjectCannotComunicateWithPCS,

        /// <remarks/>
        ProjectPCSSessionInvalid,

        /// <remarks/>
        ProjectPublishFailure,

        /// <remarks/>
        ProjectCurrencyConflict,

        /// <remarks/>
        ProjectPublishFailed,

        /// <remarks/>
        ProjectReversePublishFailure,

        /// <remarks/>
        ProjectReversePublishFailed,

        /// <remarks/>
        ProjectArchiveRetentionDeleteFailure,

        /// <remarks/>
        ProjectDeleteFailure,

        /// <remarks/>
        ProjectPublishEnqueueFailure,

        /// <remarks/>
        ProjectCheckinFailure,

        /// <remarks/>
        ProjectCheckinFailed,

        /// <remarks/>
        ProjectCheckoutFailed,

        /// <remarks/>
        ProjectPublishSummaryEnqueueFailure,

        /// <remarks/>
        ProjectPublishSummaryFailed,

        /// <remarks/>
        ProjectUpdateScheduledProjectFailure,

        /// <remarks/>
        ReportingAttributeCubeSettingsChangedMessageFailed,

        /// <remarks/>
        ReportingBaseCalendarChangeMessageFailed,

        /// <remarks/>
        ReportingCustomFieldMetadataChangeMessageFailed,

        /// <remarks/>
        ReportingEntityUserViewChangedMessageFailed,

        /// <remarks/>
        ReportingFiscalPeriodChangeMessageFailed,

        /// <remarks/>
        ReportingLookupTableChangeMessageFailed,

        /// <remarks/>
        ReportingProjectChangeMessageFailed,

        /// <remarks/>
        ReportingResourceCapacityUpdateMessageFailed,

        /// <remarks/>
        ReportingResourceChangeMessageFailed,

        /// <remarks/>
        ReportingTimesheetAdjustMessageFailed,

        /// <remarks/>
        ReportingTimesheetClassCreateMessageFailed,

        /// <remarks/>
        ReportingTimesheetDeleteMessageFailed,

        /// <remarks/>
        ReportingTimesheetPeriodDeleteMessageFailed,

        /// <remarks/>
        ReportingTimesheetPeriodMessageFailed,

        /// <remarks/>
        ReportingTimesheetSaveMessageFailed,

        /// <remarks/>
        ReportingTimesheetStatusChangeMessageFailed,

        /// <remarks/>
        ReportingWSSSyncMessageFailed,

        /// <remarks/>
        ReportingGetSPWebFailed,

        /// <remarks/>
        ReportingWssSyncListFailed,

        /// <remarks/>
        ReportingWssTransferLinksFailed,

        /// <remarks/>
        ReportingQueueMessageSubmitFailed,

        /// <remarks/>
        ReportingWssSyncHRefFailed,

        /// <remarks/>
        ReportingSyncGlobalDataMessageFailed,

        /// <remarks/>
        ReportingRDBRefreshMessageFailed,

        /// <remarks/>
        ReportingAttributeCubeDepartmentsChangedMessageFailed,

        /// <remarks/>
        ReportingTimesheetProjectAggregationMessageFailed,

        /// <remarks/>
        ReportingRdbBulkDataSyncMessageFailed,

        /// <remarks/>
        ReportingWorkflowMetadataSyncMessageFailed,

        /// <remarks/>
        ReportingProjectWorkflowInformationSyncMessageFailed,

        /// <remarks/>
        ReportingEptSyncMessageFailed,

        /// <remarks/>
        ReportingSummaryProjectPublishMessageFailed,

        /// <remarks/>
        ReportingSolutionCommitedDecisionChangedMessageFailed,

        /// <remarks/>
        ReportingDelayedUpgradeFailed,

        /// <remarks/>
        ResourceNotFound,

        /// <remarks/>
        ResourceAlreadyExists,

        /// <remarks/>
        ResourceCheckedoutToOtherUser,

        /// <remarks/>
        ResourceUIDInvalid,

        /// <remarks/>
        ResourceNameInvalid,

        /// <remarks/>
        ResourceNameTooLong,

        /// <remarks/>
        ResourceInitialsTooLong,

        /// <remarks/>
        ResourceCheckedout,

        /// <remarks/>
        ResourceNTAccountInvalid,

        /// <remarks/>
        ResourceNTAccountAlreadyInUse,

        /// <remarks/>
        ResourceAdGuidAlreadyInUse,

        /// <remarks/>
        ResourceHasActuals,

        /// <remarks/>
        ResourceNTAccountTooLong,

        /// <remarks/>
        ResourceEMailAddressTooLong,

        /// <remarks/>
        ResourceCodeTooLong,

        /// <remarks/>
        ResourceGroupTooLong,

        /// <remarks/>
        ResourceWorkGroupInvalid,

        /// <remarks/>
        ResourceTypeInvalid,

        /// <remarks/>
        ResourceNonWorkResourceWithEMailInvalid,

        /// <remarks/>
        rsResourceNameHasTrailingOrLeadingWhitespace,

        /// <remarks/>
        ResourceCannotDeleteCallingUserAccount,

        /// <remarks/>
        ResourceInitialsInvalid,

        /// <remarks/>
        ResourceAccrueAtInvalid,

        /// <remarks/>
        ResourceNonMaterialResourceCannotHaveMaterialLabel,

        /// <remarks/>
        ResourceMaterialResourceCannotHaveCertainFields,

        /// <remarks/>
        ResourceAvailFromAvailToOverlap,

        /// <remarks/>
        ResourceInvalidEmailLanguage,

        /// <remarks/>
        ResourceBookingTypeInvalid,

        /// <remarks/>
        ResourceCannotReplaceMaterialResourceWithNonMaterialResource,

        /// <remarks/>
        ResourceCannotUpdateEnterpriseResource,

        /// <remarks/>
        rsResourceCannotAddLocalWithSameNameAsEnterprise,

        /// <remarks/>
        ResourceCannotSetRateOnCostResource,

        /// <remarks/>
        ResourceCannotSetRateOnMaterialResource,

        /// <remarks/>
        ResourceCannotSetCanLevelOnNonWorkResource,

        /// <remarks/>
        ResourceCannotDeleteThisUser,

        /// <remarks/>
        ResourceCannotDeactivateSelf,

        /// <remarks/>
        ResourceAvailabilityDateRangesOverlap,

        /// <remarks/>
        ResourceAvailabilityOutsideTheHireAndTerminationDateRange,

        /// <remarks/>
        ResourceFilterInvalid,

        /// <remarks/>
        ResourceSegmentWithThisEffectiveDateDoesNotExist,

        /// <remarks/>
        ResourceSegmentWithThisEffectiveDateAlready,

        /// <remarks/>
        ResourceUserHasItemCheckedOutToItStill,

        /// <remarks/>
        ResourceInvalidHireDate,

        /// <remarks/>
        ResourceInvalidTerminationDate,

        /// <remarks/>
        ResourceCannotChangeExistingResourceType,

        /// <remarks/>
        ResourceCannotSetTimesheetManagerOnSpecifiedResource,

        /// <remarks/>
        ResourceInvalidTimesheetManager,

        /// <remarks/>
        ResourceInvalidAssignmentOwner,

        /// <remarks/>
        ResourceCannotCreateCostResource,

        /// <remarks/>
        ResourceInvalidRbsValue,

        /// <remarks/>
        ResourceCannotSetAssignmentOwnerOnSpecifiedResource,

        /// <remarks/>
        ResourceFieldsInvalidForBudget,

        /// <remarks/>
        ResourceHyperlinkInvalid,

        /// <remarks/>
        ResourceAuthorizationValidOnlyOnWorkResources,

        /// <remarks/>
        ResourceIsProjectOwner,

        /// <remarks/>
        ResourceIsTimesheetManager,

        /// <remarks/>
        ResourceIsDefaultAssignmentOwner,

        /// <remarks/>
        ResourceIsAssignmentOwner,

        /// <remarks/>
        ResourceIsUsedInResourcePlan,

        /// <remarks/>
        ResourceCannotDeleteEnterpriseResource,

        /// <remarks/>
        ResourceSetResourceAuthorizationFailed,

        /// <remarks/>
        ResourceTooManyResourcesSpecifiedToDelete,

        /// <remarks/>
        ResourceTooManyResourcesReturned,

        /// <remarks/>
        ResourceCannotDeleteWorkflowProxyUser,

        /// <remarks/>
        ResourceInvalidEmailWithExchangeSync,

        /// <remarks/>
        ResourceInvalidResourceTypeWithExchangeSync,

        /// <remarks/>
        ResourceInvalidPrincipalNameWithExchangeSync,

        /// <remarks/>
        ResourceInvalidAuthenticationTypeWithExchangeSync,

        /// <remarks/>
        ResourceExchangeSyncFlagAndPrincipalNameMismatch,

        /// <remarks/>
        ResourceUnsupportedUserUpdateInSharePointSecurityMode,

        /// <remarks/>
        ResourceUserResourceCannotBeGenericResource,

        /// <remarks/>
        RestoreProjectFailed,

        /// <remarks/>
        RestoreCustomFieldsFailed,

        /// <remarks/>
        RestoreSystemSettingsFailed,

        /// <remarks/>
        RestoreCategoriesFailed,

        /// <remarks/>
        RestoreViewsFailed,

        /// <remarks/>
        RestoreGlobalProjectFailed,

        /// <remarks/>
        RestoreResourcesFailed,

        /// <remarks/>
        RulesNameTooLong,

        /// <remarks/>
        RulesDescriptionTooLong,

        /// <remarks/>
        RulesInvalidRuleType,

        /// <remarks/>
        RulesInvalidConditionType,

        /// <remarks/>
        RulesInvalidOperatorType,

        /// <remarks/>
        RulesInvalidListItemType,

        /// <remarks/>
        RulesNameInvalidCharacters,

        /// <remarks/>
        RulesDescriptionInvalidCharacters,

        /// <remarks/>
        RulesInvalidValueType,

        /// <remarks/>
        SecurityObjectNotFound,

        /// <remarks/>
        SecurityGroupCouldNotBeCreated,

        /// <remarks/>
        SecurityFieldAccessIDInvalid,

        /// <remarks/>
        SecurityCannotUpdateFacForNonExistentCategory,

        /// <remarks/>
        SecurityDuplicateCategoryUid,

        /// <remarks/>
        SecurityDuplicateGroupUid,

        /// <remarks/>
        SecurityDuplicateTemplateUid,

        /// <remarks/>
        SecurityDuplicateUid,

        /// <remarks/>
        SecurityInvalidTemplateUidRef,

        /// <remarks/>
        SecurityInvalidCategoryUidRef,

        /// <remarks/>
        SecurityInvalidProjectUidRef,

        /// <remarks/>
        SecurityInvalidGroupUidRef,

        /// <remarks/>
        SecurityInvalidUserUidRef,

        /// <remarks/>
        SecurityInvalidCategoryPermissionUidRef,

        /// <remarks/>
        SecurityInvalidGlobalPermissionUidRef,

        /// <remarks/>
        SecurityInvalidResourceUidRef,

        /// <remarks/>
        SecurityInvalidGlobalPermission,

        /// <remarks/>
        SecurityInvalidCategoryPermission,

        /// <remarks/>
        SecurityInvalidObjectType,

        /// <remarks/>
        SecurityUpdatedGroupNotFound,

        /// <remarks/>
        SecurityUpdatedCategoryNotFound,

        /// <remarks/>
        SecurityUpdatedTemplateNotFound,

        /// <remarks/>
        SecurityTemplateNotFound,

        /// <remarks/>
        SecurityGroupMemberNotFound,

        /// <remarks/>
        SecurityDeleteNotSupportedBySetMethod,

        /// <remarks/>
        SecurityUserNotFound,

        /// <remarks/>
        SecurityNoCategoryRelationForPermission,

        /// <remarks/>
        SecurityCannotDeleteDefaultGroup,

        /// <remarks/>
        SecurityCannotDeleteDefaultCategory,

        /// <remarks/>
        SecurityCategoryCouldNotBeCreated,

        /// <remarks/>
        SecurityNoCategoryForPermission,

        /// <remarks/>
        SecurityNoCategoryForObject,

        /// <remarks/>
        SecurityNoCategoryForRule,

        /// <remarks/>
        SecurityNoGroupForPermission,

        /// <remarks/>
        SecurityCannotSetPermissionForFieldGroup,

        /// <remarks/>
        SecurityInvalidFieldGroup,

        /// <remarks/>
        SecurityCannotSetOrgPermission,

        /// <remarks/>
        SecurityInvalidOrgPermission,

        /// <remarks/>
        SecurityInvalidSecurityRule,

        /// <remarks/>
        SecurityInvalidProjectCategoryPermissionUidRef,

        /// <remarks/>
        SecurityCannotModifyCoreProjectCategoryDataInUpdate,

        /// <remarks/>
        SecurityProjectCategoryEntitiesDoNotAllowInPlaceChanges,

        /// <remarks/>
        SecurityCategoryCannotAddRelationForDeletedCategory,

        /// <remarks/>
        SecurityCategoryCannotAddPermissionForDeletedCategory,

        /// <remarks/>
        SecurityCategoryCannotAddPermissionForDeletedRelation,

        /// <remarks/>
        SecurityCategoryCannotDeleteRelationForNewlyAddedCategory,

        /// <remarks/>
        SecurityCategoryCannotDeletePermissionForNewlyAddedCategory,

        /// <remarks/>
        SecurityCategoryCannotDeletePermissionForNewlyAddedRelation,

        /// <remarks/>
        SecurityCategoryCannotHaveDuplicateUserOrGroupUidsForRelation,

        /// <remarks/>
        SecurityCategoryPermissionMustHaveMatchingRelation,

        /// <remarks/>
        SecurityCategoryProjectAlreadyHasSecurityProjectCategory,

        /// <remarks/>
        ServerEventInvalidEventId,

        /// <remarks/>
        ServerEventServiceNotFound,

        /// <remarks/>
        ServerEventRemoteCouldNotReachProxy,

        /// <remarks/>
        ServerEventManagerCouldNotReachRemote,

        /// <remarks/>
        ServerEventHandlerNotSigned,

        /// <remarks/>
        ServerEventHandlerMalformedAssemblyName,

        /// <remarks/>
        ServerEventHandlerOrderInvalid,

        /// <remarks/>
        ServerEventHandlerDuplicateEntry,

        /// <remarks/>
        ServerEventHandlerNotFound,

        /// <remarks/>
        ServerEventHandlerDuplicateName,

        /// <remarks/>
        ServerEventHandlerNullAssemblyNameAndEndpointUrl,

        /// <remarks/>
        StatusingInvalidEntity,

        /// <remarks/>
        StatusingGetDataForTaskFailed,

        /// <remarks/>
        StatusingGetTaskOrAssnCntrFailed,

        /// <remarks/>
        StatusingInvalidPIDForProjCntr,

        /// <remarks/>
        StatusingDeleteAssnFailed,

        /// <remarks/>
        StatusingAssnSaveFailed,

        /// <remarks/>
        StatusingTaskSaveFailed,

        /// <remarks/>
        StatusingInvalidPID,

        /// <remarks/>
        StatusingSetDataValueInvalid,

        /// <remarks/>
        StatusingSetDataFailed,

        /// <remarks/>
        StatusingInvalidDelegationStart,

        /// <remarks/>
        StatusingApprovalUpdateFailed,

        /// <remarks/>
        StatusingInvalidApprovalType,

        /// <remarks/>
        StatusingInternalError,

        /// <remarks/>
        StatusingInvalidUpdateData,

        /// <remarks/>
        StatusingProjectUpdateFailed,

        /// <remarks/>
        StatusingInvalidPreviewData,

        /// <remarks/>
        StatusingInvalidTransaction,

        /// <remarks/>
        StatusingTooManyResults,

        /// <remarks/>
        StatusingInvalidInterval,

        /// <remarks/>
        StatusingApplyUpdatesFailed,

        /// <remarks/>
        StatusingApplyUpdatesFailure,

        /// <remarks/>
        StatusingInvalidWorkData,

        /// <remarks/>
        StatusingMissingNameAttribute,

        /// <remarks/>
        StatusingInvalidNameAttribute,

        /// <remarks/>
        StatusingInvalidData,

        /// <remarks/>
        StatusingInvalidChangelist,

        /// <remarks/>
        StatusingInsufficientAssignmentRights,

        /// <remarks/>
        StatusingInvalidChangeNumber,

        /// <remarks/>
        StatusingPidNotEditable,

        /// <remarks/>
        StatusingCannotSetTimephasedDataInManualTasks,

        /// <remarks/>
        StatusingCannotChangeTaskMode,

        /// <remarks/>
        StatusReportsUnknownError,

        /// <remarks/>
        StatusReportsPeriodUnmatched,

        /// <remarks/>
        StatusReportsPeriodUnavailable,

        /// <remarks/>
        StatusReportsInvalidFormInput,

        /// <remarks/>
        SRAInvalidVersion,

        /// <remarks/>
        SRADelayedUpgradeFailed,

        /// <remarks/>
        TaskIDInvalid,

        /// <remarks/>
        TaskNameTooLong,

        /// <remarks/>
        TaskTypeInvalid,

        /// <remarks/>
        TaskPriorityInvalid,

        /// <remarks/>
        TaskConstraintTypeInvalid,

        /// <remarks/>
        TaskNameInvalid,

        /// <remarks/>
        TaskConstraintTypeRequiresConstraint,

        /// <remarks/>
        TaskConstraintTypeCannotHaveConstraintDate,

        /// <remarks/>
        TaskSummaryTaskCannotBeMilestone,

        /// <remarks/>
        TaskFixedCostAccrualInvalid,

        /// <remarks/>
        TaskPercentCompleteInvalid,

        /// <remarks/>
        TaskWorkPercentCompleteInvalid,

        /// <remarks/>
        TaskPhysicalPercentCompleteInvalid,

        /// <remarks/>
        TaskLinkTypeInvalid,

        /// <remarks/>
        TaskAlreadyExists,

        /// <remarks/>
        TaskLinkAlreadyExists,

        /// <remarks/>
        TaskNotFound,

        /// <remarks/>
        TaskLinkNotFound,

        /// <remarks/>
        TaskLinkLagInvalid,

        /// <remarks/>
        TaskUnableToInsert,

        /// <remarks/>
        TaskAddPositionInvalid,

        /// <remarks/>
        TaskOutlineLevelInvalid,

        /// <remarks/>
        TaskDurationFormatInvalid,

        /// <remarks/>
        TaskCannotAddWhereSpecified,

        /// <remarks/>
        TaskEarnedValueMethodInvalid,

        /// <remarks/>
        TaskCannotModifyProjectSummary,

        /// <remarks/>
        TaskCannotDeleteProjectSummary,

        /// <remarks/>
        TaskCannotSetActualCost,

        /// <remarks/>
        TaskLevelingDelayInvalid,

        /// <remarks/>
        TaskCannotEditSummary,

        /// <remarks/>
        TaskCannotCreateSubTasksUnderTasksWithAssignments,

        /// <remarks/>
        TaskCannotDeleteSubProject,

        /// <remarks/>
        TaskCannotEditExternal,

        /// <remarks/>
        TaskCannotDeleteExternal,

        /// <remarks/>
        TaskLinkCannotDeleteExternal,

        /// <remarks/>
        TaskCannotModifyNullTask,

        /// <remarks/>
        TaskCannotModifyLeafTaskWithNoAssignment,

        /// <remarks/>
        TaskCannotModifyExternalTask,

        /// <remarks/>
        TaskStatusManagerInvalid,

        /// <remarks/>
        TaskLinkCyclicDependency,

        /// <remarks/>
        TaskCannotCreateOrModifySubTasksUnderTasksWithAssignments,

        /// <remarks/>
        TaskLinkCannotEditExternal,

        /// <remarks/>
        TimesheetMaxHourPerDayExceeded,

        /// <remarks/>
        TimesheetHoursPerTSLimitExceeded,

        /// <remarks/>
        TimesheetUnverifiedTSLineNotAllowed,

        /// <remarks/>
        TimesheetIncorrectMode,

        /// <remarks/>
        TimesheetInvalidApprover,

        /// <remarks/>
        TimesheetFutureReportingNotAllowed,

        /// <remarks/>
        TimesheetIncorrectPeriod,

        /// <remarks/>
        TimesheetPeriodClosed,

        /// <remarks/>
        TimesheetPendingLines,

        /// <remarks/>
        TimesheetInvalidDateRange,

        /// <remarks/>
        TimesheetLineClassDisabled,

        /// <remarks/>
        TimesheetLineHasNonExistentItem,

        /// <remarks/>
        TimesheetLineInvalidStatus,

        /// <remarks/>
        WSSCreateSiteFailure,

        /// <remarks/>
        WSSCannotCreateWebWithBlankName,

        /// <remarks/>
        WSSWebAlreadyExists,

        /// <remarks/>
        WSSInvalidProjectUID,

        /// <remarks/>
        WSSProjectAlreadyHasSpWeb,

        /// <remarks/>
        WSSWebDoesNotExist,

        /// <remarks/>
        WSSSpWebAlreadyLinkedToProject,

        /// <remarks/>
        WSSWebHierarchyDoesNotExist,

        /// <remarks/>
        WSSSPWebHasChildren,

        /// <remarks/>
        WSSURIInvalidFormat,

        /// <remarks/>
        WSSSyncReportingDataFailed,

        /// <remarks/>
        WSSWorkspaceUrlPathTooLong,

        /// <remarks/>
        WSSWorkspaceNameContainsIllegalChars,

        /// <remarks/>
        WSSInvalidWssServerUid,

        /// <remarks/>
        WSSSyncUsersFailed,

        /// <remarks/>
        WSSWrongWebTemplateLCID,

        /// <remarks/>
        WSSWrongWebTemplate,

        /// <remarks/>
        WSSWebIsNotProjectWorkspace,

        /// <remarks/>
        WSSWebCannotStartOrEndOnPeriod,

        /// <remarks/>
        WSSCannotDeleteSiteCollection,

        /// <remarks/>
        WSSListUidInvalid,

        /// <remarks/>
        WSSSyncDataSetListUidMismatch,

        /// <remarks/>
        WSSSyncDataSetMissingProjectSettingsRow,

        /// <remarks/>
        WSSSyncDataSetTaskMappingsNotAllowed,

        /// <remarks/>
        WSSSyncDataSetWssListUidEmpty,

        /// <remarks/>
        WSSSyncDataNotFound,

        /// <remarks/>
        WSSSyncCriticalDataValidationError,

        /// <remarks/>
        WSSSyncSharePointListNotAccessibleError,

        /// <remarks/>
        WSSSyncInvalidEntityUids,

        /// <remarks/>
        WSSSyncInvalidSyncData,

        /// <remarks/>
        WSSSyncSPSummaryTaskAssignedToResourceError,

        /// <remarks/>
        WSSSyncInsufficientPermissionsToCreateWinUser,

        /// <remarks/>
        WSSSyncNoDefaultValueForCustomField,

        /// <remarks/>
        WSSOLPCreateLinkFailure,

        /// <remarks/>
        WSSOLPDeleteWebObjectLinkError,

        /// <remarks/>
        WSSInvalidPermissionsToWssList,

        /// <remarks/>
        WSSWebIsNotUnderDefaultCollection,

        /// <remarks/>
        WSSWorkspaceUrlIsNotUnderPrimaryCollection,

        /// <remarks/>
        WSSWorkspacesMustBeRestrictedToDefaultCollection,

        /// <remarks/>
        AdSyncUpdateTimerJobFailed,

        /// <remarks/>
        AdSyncDeleteTimerJobFailed,

        /// <remarks/>
        AdSyncAdConnectFail,

        /// <remarks/>
        AdMaximumGroupsCountExceeded,

        /// <remarks/>
        ResourcePlanProjectPublishIncomplete,

        /// <remarks/>
        ResourcePlanInvalidResourceType,

        /// <remarks/>
        ResourcePlanInactiveResourcesDisallowed,

        /// <remarks/>
        ResourcePlanFilterInvalid,

        /// <remarks/>
        ResourcePlanSaveFailure,

        /// <remarks/>
        ResourcePlanCheckinFailure,

        /// <remarks/>
        ResourcePlanDeleteFailure,

        /// <remarks/>
        ResourcePlanInvalidUtilizationType,

        /// <remarks/>
        ResourcePlanInvalidTimescale,

        /// <remarks/>
        ResourcePlanMismatchedJobList,

        /// <remarks/>
        ResourcePlanAlreadyExists,

        /// <remarks/>
        ResourcePlanInvalidProjectUID,

        /// <remarks/>
        ResourcePlanResourceAlreadyExists,

        /// <remarks/>
        PlannerSolutionMessageDeleteFailed,

        /// <remarks/>
        PlannerSolutionMessageCreateFailed,

        /// <remarks/>
        PlannerInvalidRBSValueUid,

        /// <remarks/>
        PlannerInvalidCustomFieldUid,

        /// <remarks/>
        PlannerHorizonInvalid,

        /// <remarks/>
        PlannerHorizonTooBig,

        /// <remarks/>
        PlannerInvalidBookingType,

        /// <remarks/>
        PlannerInvalidTimeScale,

        /// <remarks/>
        PlannerInvalidProjectSNET,

        /// <remarks/>
        PlannerInvalidProjectFNLT,

        /// <remarks/>
        PlannerInvalidAnalysisStartDate,

        /// <remarks/>
        PlannerInvalidAnalysisDuration,

        /// <remarks/>
        PlannerInvalidHorizonStartDate,

        /// <remarks/>
        PlannerInvalidHorizonEndDate,

        /// <remarks/>
        PlannerInvalidHorizonTimeScale,

        /// <remarks/>
        PlannerInvalidAnalysisType,

        /// <remarks/>
        PlannerHorizonStartDateDoesNotMatchTimeScale,

        /// <remarks/>
        PlannerHorizonEndDateDoesNotMatchTimeScale,

        /// <remarks/>
        PlannerAnalysisNoCapacityData,

        /// <remarks/>
        PlannerInvalidSolutionUid,

        /// <remarks/>
        PlannerInvalidOptimizerSolutionUid,

        /// <remarks/>
        PlannerInvalidLookupTableValueUid,

        /// <remarks/>
        PlannerInvalidEfficientFrontierUid,

        /// <remarks/>
        PlannerInvalidProjectUid,

        /// <remarks/>
        PlannerInvalidAllocationThreshold,

        /// <remarks/>
        PlannerInvalidHiringType,

        /// <remarks/>
        PlannerInvalidConstraintType,

        /// <remarks/>
        PlannerInvalidConstraintValue,

        /// <remarks/>
        PlannerInvalidRateTable,

        /// <remarks/>
        PlannerInvalidSolutionForConstraint,

        /// <remarks/>
        PlannerInvalidSolutionForDependencies,

        /// <remarks/>
        PlannerInvalidSolutionForScheduling,

        /// <remarks/>
        PlannerInvalidAnalysisUid,

        /// <remarks/>
        PlannerInvalidProjectStartDate,

        /// <remarks/>
        PlannerInvalidProjectEndDate,

        /// <remarks/>
        PlannerInvalidProjectFNLTDate,

        /// <remarks/>
        PlannerInvalidProjectSNETDate,

        /// <remarks/>
        PlannerInvalidProjectDuration,

        /// <remarks/>
        PlannerCannotCreateSolution,

        /// <remarks/>
        PlannerCannotUpdateSolution,

        /// <remarks/>
        PlannerCannotDeleteSolution,

        /// <remarks/>
        PlannerCannotCreateMultipleSolutions,

        /// <remarks/>
        PlannerCannotUpdateMultipleSolutions,

        /// <remarks/>
        PlannerTableIsReadOnly,

        /// <remarks/>
        PlannerCannotCommitSolution,

        /// <remarks/>
        PlannerFieldIsReadOnly,

        /// <remarks/>
        PlannerProjectNotInParentSolution,

        /// <remarks/>
        PlannerProjectNotSelectedInParentSolution,

        /// <remarks/>
        PlannerProjectNotInParentAnalysis,

        /// <remarks/>
        PlannerProjectBeyondHorizon,

        /// <remarks/>
        PlannerResourceAllocationInternalError,

        /// <remarks/>
        PlannerResourceAllocationInfeasibleSolution,

        /// <remarks/>
        PlannerProjectEndDateViolatesDependency,

        /// <remarks/>
        PlannerInvalidProjectsSet,

        /// <remarks/>
        PlannerInvalidInputData,

        /// <remarks/>
        PlannerDecimalOverflowError,

        /// <remarks/>
        PlannerSolutionMismatchedJobList,

        /// <remarks/>
        PlannerInvalidForceLookupTableValue,

        /// <remarks/>
        PlannerNoHiredResource,

        /// <remarks/>
        OptimizerDepInvalidDepType,

        /// <remarks/>
        OptimizerDepInvalidEntityType,

        /// <remarks/>
        OptimizerDepInvalidPosition,

        /// <remarks/>
        OptimizerDepDuplicateDependentProjects,

        /// <remarks/>
        OptimizerDepInvalidDependency,

        /// <remarks/>
        OptimizerDepCircularDependency,

        /// <remarks/>
        OptimizerCannotDeleteDependency,

        /// <remarks/>
        OptimizerCannotCreateDependency,

        /// <remarks/>
        OptimizerCannotUpdateDependency,

        /// <remarks/>
        OptimizerCannotCreateMultipleDependencies,

        /// <remarks/>
        OptimizerCannotUpdateMultipleDependencies,

        /// <remarks/>
        OptimizerEngineMatrixNotFilled,

        /// <remarks/>
        OptimizerEngineCustomFieldIsNotAConstraint,

        /// <remarks/>
        OptimizerCouldNotCalculatePrioritiesFromCustomFields,

        /// <remarks/>
        OptimizerEngineBinaryInfeasibleSolution,

        /// <remarks/>
        OptimizerEngineBinaryNumericalError,

        /// <remarks/>
        OptimizerEngineBinaryTimedOut,

        /// <remarks/>
        OptimizerEngineBinaryMaxedIterations,

        /// <remarks/>
        OptimizerEngineBinarySubOptimal,

        /// <remarks/>
        OptimizerEngineBinaryInternalError,

        /// <remarks/>
        OptimizerInvalidRange,

        /// <remarks/>
        OptimizerNonNormalizedWeights,

        /// <remarks/>
        OptimizerCannotEditPrioritization,

        /// <remarks/>
        OptimizerCannotDeletePrioritization,

        /// <remarks/>
        OptimizerCannotCreatePrioritization,

        /// <remarks/>
        OptimizerCannotUpdatePrioritization,

        /// <remarks/>
        OptimizerCannotCalculateDriverPriorities,

        /// <remarks/>
        OptimizerCannotCreateMultiplePrioritizations,

        /// <remarks/>
        OptimizerCannotUpdateMultiplePrioritizations,

        /// <remarks/>
        OptimizerDriverRelationsNotFilled,

        /// <remarks/>
        OptimizerDriversNotFilled,

        /// <remarks/>
        OptimizerDriverRelationsInvalidInversedValue,

        /// <remarks/>
        OptimizerCannotCreatePrioritizationUsingInactiveDrivers,

        /// <remarks/>
        OptimizerCannotChangePrioritizationType,

        /// <remarks/>
        OptimizerCannotSpecifyPriorityValuesForCalculatedPrioritizations,

        /// <remarks/>
        OptimizerCannotNormalizePriorityValues,

        /// <remarks/>
        OptimizerTooManyDriversInPrioritization,

        /// <remarks/>
        OptimizerInvalidProjectImpactValue,

        /// <remarks/>
        OptimizerCannotDeleteDriver,

        /// <remarks/>
        OptimizerCannotCreateDriver,

        /// <remarks/>
        OptimizerCannotUpdateDriver,

        /// <remarks/>
        OptimizerCannotEditDriver,

        /// <remarks/>
        OptimizerCannotCreateMultipleDrivers,

        /// <remarks/>
        OptimizerCannotUpdateMultipleDrivers,

        /// <remarks/>
        OptimizerInvalidRelativeImportanceValue,

        /// <remarks/>
        OptimizerInvalidDriverUid,

        /// <remarks/>
        OptimizerInvalidEntityType,

        /// <remarks/>
        OptimizerInvalidProjectUid,

        /// <remarks/>
        OptimizerInvalidCustomFieldUid,

        /// <remarks/>
        OptimizerInvalidHardConstraintUid,

        /// <remarks/>
        OptimizerInvalidAnalysisUid,

        /// <remarks/>
        OptimizerDriverFilterInvalid,

        /// <remarks/>
        OptimizerPrioritizationFilterInvalid,

        /// <remarks/>
        OptimizerCannotLoadOptimizationEngine,

        /// <remarks/>
        OptimizerAnalysisFilterInvalid,

        /// <remarks/>
        OptimizerSolutionFilterInvalid,

        /// <remarks/>
        OptimizerDependenciesFilterInvalid,

        /// <remarks/>
        OptimizerInvalidSolutionUid,

        /// <remarks/>
        OptimizerInvalidViewUid,

        /// <remarks/>
        OptimizerInvalidAnalysisType,

        /// <remarks/>
        OptimizerInvalidPrioritizationType,

        /// <remarks/>
        OptimizerCannotDeleteAnalysis,

        /// <remarks/>
        OptimizerCannotCreateAnalysis,

        /// <remarks/>
        OptimizerCannotUpdateAnalysis,

        /// <remarks/>
        OptimizerInvalidPrioritizationUid,

        /// <remarks/>
        OptimizerCannotCreateMultipleAnalyses,

        /// <remarks/>
        OptimizerCannotUpdateMultipleAnalyses,

        /// <remarks/>
        OptimizerCannotCalculateProjectPriorities,

        /// <remarks/>
        OptimizerCannotDeleteAnalysisProjectImpact,

        /// <remarks/>
        OptimizerCannotChangeAnalysisProjects,

        /// <remarks/>
        OptimizerCannotChangePriorityData,

        /// <remarks/>
        OptimizerCannotEditAnalysis,

        /// <remarks/>
        OptimizerInvalidPlannerData,

        /// <remarks/>
        OptimizerCannotChangeImpactData,

        /// <remarks/>
        OptimizerInvalidProjectsNumber,

        /// <remarks/>
        OptimizerCannotAddImpactCFUIDToCFAnalysis,

        /// <remarks/>
        OptimizerInvalidDepartmentUid,

        /// <remarks/>
        OptimizerTooManyProjectsInAnalysis,

        /// <remarks/>
        QueueAnalysisCannotDeleteAnalysis,

        /// <remarks/>
        QueueAnalysisCannotCreateAnalysis,

        /// <remarks/>
        QueueAnalysisCannotUpdateAnalysis,

        /// <remarks/>
        AnalysisMismatchedJobList,

        /// <remarks/>
        OptimizerInvalidForceInLookupTableUid,

        /// <remarks/>
        OptimizerInvalidForceOutLookupTableUid,

        /// <remarks/>
        OptimizerDuplicateForceLookupTableUids,

        /// <remarks/>
        OptimizerInvalidDecisionResult,

        /// <remarks/>
        OptimizerInvalidForcedStatus,

        /// <remarks/>
        OptimizerCannotDeleteSolution,

        /// <remarks/>
        OptimizerCannotCreateSolution,

        /// <remarks/>
        OptimizerCannotUpdateSolution,

        /// <remarks/>
        OptimizerCannotCalculateSolutionStrategicAlignment,

        /// <remarks/>
        OptimizerCannotCreateMultipleSolutions,

        /// <remarks/>
        OptimizerCannotUpdateMultipleSolutions,

        /// <remarks/>
        OptimizerCannotAddPrioritizationToCFAnalysis,

        /// <remarks/>
        OptimizerTableIsReadOnly,

        /// <remarks/>
        OptimizerSolutionCreateMessageFailed,

        /// <remarks/>
        OptimizerSolutionDeleteMessageFailed,

        /// <remarks/>
        OptimizerCannotCalculateEfficientFrontier,

        /// <remarks/>
        OptimizerCannotUpdateSolutionProperties,

        /// <remarks/>
        OptimizerInvalidConstraintPosition,

        /// <remarks/>
        OptimizerInvalidHardConstraintPosition,

        /// <remarks/>
        OptimizerInvalidConstraintLimit,

        /// <remarks/>
        OptimizerInvalidConstraintValue,

        /// <remarks/>
        OptimizerInvalidSolutionProjectsSet,

        /// <remarks/>
        OptimizerCannotCommitSolution,

        /// <remarks/>
        OptimizerInvalidInputData,

        /// <remarks/>
        OptimizerInvalidConstraintSet,

        /// <remarks/>
        OptimizerCannotUpdateAnalysisMetrics,

        /// <remarks/>
        OptimizerSolutionMismatchedJobList,

        /// <remarks/>
        OptimizerInvalidForceLookupTableValue,

        /// <remarks/>
        OptimizerCannotCreateSolutionWhileAnalysisUpdateIsPending,

        /// <remarks/>
        OptimizerProjectSelectorAtLeastOne,

        /// <remarks/>
        WorkflowPhasesCannotCreatePhase,

        /// <remarks/>
        WorkflowPhasesCannotUpdatePhase,

        /// <remarks/>
        WorkflowPhasesCannotDeletePhase,

        /// <remarks/>
        WorkflowPhaseNameIsRequired,

        /// <remarks/>
        WorkflowStagesCannotCreateStage,

        /// <remarks/>
        WorkflowStagesCannotUpdateStage,

        /// <remarks/>
        WorkflowStagesCannotDeleteStage,

        /// <remarks/>
        WorkflowStagesProjectsInStage,

        /// <remarks/>
        WorkflowCannotAccessPDPLibrary,

        /// <remarks/>
        WorkflowInvalidPDPUid,

        /// <remarks/>
        WorkflowInvalidCustomFieldUid,

        /// <remarks/>
        WorkflowCustomFieldNotWorkflowControlled,

        /// <remarks/>
        WorkflowCustomFieldCannotBeRequiredAndReadOnly,

        /// <remarks/>
        WorkflowInvalidWorkflowPhaseUid,

        /// <remarks/>
        WorkflowInsertWorkflowPhaseNotAllowed,

        /// <remarks/>
        WorkflowInvalidWorkflowStageUid,

        /// <remarks/>
        WorkflowPhaseHasStages,

        /// <remarks/>
        WorkflowStageNameIsRequired,

        /// <remarks/>
        WorkflowStageAtLeastOnePDPIsRequired,

        /// <remarks/>
        WorkflowCannotStartWorkflow,

        /// <remarks/>
        WorkflowStatusCannotUpdateStatus,

        /// <remarks/>
        WorkflowOnlyProjectsHaveWorkflow,

        /// <remarks/>
        WorkflowNoWorkflowsDefined,

        /// <remarks/>
        WorkflowInvalidStageForProject,

        /// <remarks/>
        WorkflowNoWorkflowForProject,

        /// <remarks/>
        WorkflowCheckinRequiredAndProjectNotCheckedin,

        /// <remarks/>
        WorkflowWaitingForRequiredData,

        /// <remarks/>
        WorkflowFlagCustomFieldsCannotBeRequired,

        /// <remarks/>
        WorkflowCannotChangeWorkflow,

        /// <remarks/>
        WorkflowWorkflowStatusPDPNotAllowed,

        /// <remarks/>
        WorkflowInvalidWorkflowStatusPDPUid,

        /// <remarks/>
        WorkflowInvalidStageStatusValue,

        /// <remarks/>
        WorkflowCannotCheckinNotify,

        /// <remarks/>
        WorkflowCannotCommitNotify,

        /// <remarks/>
        WorkflowExceptionStartingWorkflow,

        /// <remarks/>
        WorkflowStatusPDPMustBeSupplied,

        /// <remarks/>
        WorkflowWorkflowProxyAccountNotFound,

        /// <remarks/>
        WorkflowInvalidCurrentStage,

        /// <remarks/>
        WorkflowMultipleStagesInProgress,

        /// <remarks/>
        WorkflowActivityInvalidArgument,

        /// <remarks/>
        WorkflowMTWConfigurationError,

        /// <remarks/>
        EnterpriseProjectTypeInvalidEnterpriseProjectTypeUid,

        /// <remarks/>
        EnterpriseProjectTypeCannotCreateEnterpriseProjectType,

        /// <remarks/>
        EnterpriseProjectTypeCannotUpdateEnterpriseProjectType,

        /// <remarks/>
        EnterpriseProjectTypeCannotDeleteEnterpriseProjectType,

        /// <remarks/>
        EnterpriseProjectTypeCannotCreateMultipleEnterpriseProjectTypes,

        /// <remarks/>
        EnterpriseProjectTypeCannotUpdateMultipleEnterpriseProjectTypes,

        /// <remarks/>
        EnterpriseProjectTypeInvalidCreatePDPUid,

        /// <remarks/>
        EnterpriseProjectTypeInvalidProjectPlanTemplateUid,

        /// <remarks/>
        EnterpriseProjectTypeInvalidWorkspaceTemplateName,

        /// <remarks/>
        EnterpriseProjectTypeInvalidWorkflowAssociationUid,

        /// <remarks/>
        EnterpriseProjectTypeCannotReadWssSettings,

        /// <remarks/>
        EnterpriseProjectTypeCannotReadWssLanguagesAndTemplates,

        /// <remarks/>
        EnterpriseProjectTypeInvalidDepartmentUid,

        /// <remarks/>
        EnterpriseProjectTypeInvalidUri,

        /// <remarks/>
        EnterpriseProjectTypeUriRequiresHttp,

        /// <remarks/>
        EnterpriseProjectTypeCannotDeleteDefault,

        /// <remarks/>
        EnterpriseProjectTypeCannotChangeDefault,

        /// <remarks/>
        EnterpriseProjectTypeHasProjectsCannotDelete,

        /// <remarks/>
        EnterpriseProjectTypeCreatePDPIsRequired,

        /// <remarks/>
        EnterpriseProjectTypeOnlyOneCreatePDPAllowed,

        /// <remarks/>
        EnterpriseProjectTypeHasWorkflowOnlyCreatePDPAllowed,

        /// <remarks/>
        EnterpriseProjectTypeInvalidData,

        /// <remarks/>
        EnterpriseProjectNoDefaultEnterpriseProjectTypeDefined,

        /// <remarks/>
        EnterpriseProjectTypeAtLeastOnePDPIsRequired,

        /// <remarks/>
        EnterpriseProjectTypeWorkflowStatusPDPNotAllowed,

        /// <remarks/>
        EnterpriseProjectTypeProjectHasAssociation,

        /// <remarks/>
        InvariantValidationPSIFailed,

        /// <remarks/>
        ValidationMethodFailed,

        /// <remarks/>
        GeneralExchangeSyncError,

        /// <remarks/>
        ExchangeSyncRootFolderCreationFailed,

        /// <remarks/>
        ExchangeSyncTaskFolderCreationFailed,

        /// <remarks/>
        ExchangeSyncCouldNotGetRootFolder,

        /// <remarks/>
        ExchangeSyncCouldNotLoadTaskObject,

        /// <remarks/>
        ExchangeSyncNewExchangeTaskCreationFailed,

        /// <remarks/>
        ExchangeSyncFailedToUpdateCacheForUser,

        /// <remarks/>
        ExchangeSyncFailedToUpdateExchangeTask,

        /// <remarks/>
        ExchangeSyncSubscriptionUpdateFailed,

        /// <remarks/>
        ExchangeSyncEWSUrlFailed,

        /// <remarks/>
        ExchangeSyncExchangeUrlRefreshFailed,

        /// <remarks/>
        ExchangeSyncExchangeSubscriptionUpdateForUserFailed,

        /// <remarks/>
        ExchangeSyncGeneralProcessingFailure,

        /// <remarks/>
        ExchangeSyncDeletionOfTasksInExchangeFailure,

        /// <remarks/>
        ExchangeSyncAttemptedSyncOfInvalidConfiguredResource,

        /// <remarks/>
        ExchangeSyncRetrievalOfEWSUrlCausedException,

        /// <remarks/>
        TimelineViewDataDoesNotExist,

        /// <remarks/>
        UserDelegationExpired,

        /// <remarks/>
        UserDelegationCannotSelfDelegate,

        /// <remarks/>
        UserDelegationInvalidDelegate,

        /// <remarks/>
        UserDelegationInvalidUser,

        /// <remarks/>
        UserDelegationInvalidDates,

        /// <remarks/>
        UserDelegationCannotDoubleDelegate,

        /// <remarks/>
        UserDelegationDelegateCannotLogon,

        /// <remarks/>
        UserDelegationDelegateIsInactive,

        /// <remarks/>
        UserDelegationInvalidFilter,

        /// <remarks/>
        UserDelegationUserCannotLogon,

        /// <remarks/>
        UserDelegationUserIsInactive,

        /// <remarks/>
        DatabaseUndefinedError,

        /// <remarks/>
        DatabaseCannotInsertDuplicateKeyError,

        /// <remarks/>
        ProjectDetailPagesStrategicImpactRatingRequired,

        /// <remarks/>
        ProjectDetailPagesMissingPDPLinks,

        /// <remarks/>
        ProjectDetailPagesUnavailableWorker,

        /// <remarks/>
        ProjectDetailPagesFailedToLoadProjectInWorker,

        /// <remarks/>
        ProjectDetailPagesWorkerBusy,

        /// <remarks/>
        ProjectDetailPagesMaxUserSessionLimitReached,

        /// <remarks/>
        ProjectDetailPagesWorkerOpenedInAnotherServer,

        /// <remarks/>
        AppPermissionInvalidAppPermissionId,

        /// <remarks/>
        CSOMDelegationNotSupported,

        /// <remarks/>
        CSOMProjectSiteDoesNotExist,

        /// <remarks/>
        CSOMCannotEnableVisibilityMode,

        /// <remarks/>
        CSOMTaskListIncompatibleWithImport,

        /// <remarks/>
        CSOMProjectSiteInUse,

        /// <remarks/>
        CSOMUnknownUser
    }
}
