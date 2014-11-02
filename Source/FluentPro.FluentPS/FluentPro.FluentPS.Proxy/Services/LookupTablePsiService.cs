using FluentPro.FluentPS.Psi.Model.DataSets;
using FluentPro.FluentPS.Psi.Network;
using System;
using System.Data;

namespace FluentPro.FluentPS.Psi.Services
{
    public class LookupTablePsiService
    {
        private readonly PsiContext _psiContext;

        public LookupTablePsiService(Uri pwaUri)
        {
            _psiContext = PsiContext.Get(pwaUri);
        }

        public void CheckOutLookupTables(Guid[] array)
        {
            _psiContext.LookupTable.CheckOutLookupTables(array);
        }

        public void CheckInLookupTables(Guid[] array, bool force)
        {
            _psiContext.LookupTable.CheckInLookupTables(array, force);
        }

        public DataSet ReadLookupTablesMultiLang(string xmlFilter, bool autoCheckOut)
        {
            return _psiContext.LookupTable.ReadLookupTablesMultiLang(xmlFilter, autoCheckOut);
        }

        public void CreateLookupTablesMultiLang(DataSet ltds, bool validateOnly, bool autoCheckIn)
        {
            _psiContext.LookupTable.CreateLookupTablesMultiLang((LookupTableMultiLangDataSet)ltds, validateOnly, autoCheckIn);
        }

        public void DeleteLookupTables(Guid[] ltGuids)
        {
            _psiContext.LookupTable.DeleteLookupTables(ltGuids);
        }

        public void UpdateLookupTablesMultiLang(DataSet ltds, bool validateOnly, bool autoCheckIn)
        {
            _psiContext.LookupTable.UpdateLookupTablesMultiLang((LookupTableMultiLangDataSet)ltds, validateOnly, autoCheckIn);
        }

        public DataSet ReadLookupTables(string xmlFilter, bool autoCheckOut, int language)
        {
            return _psiContext.LookupTable.ReadLookupTables(xmlFilter, autoCheckOut, language);
        }

        public DataSet ReadLookupTablesByUids(Guid[] ltUidList, bool autoCheckOut, int language)
        {
            return _psiContext.LookupTable.ReadLookupTablesByUids(ltUidList, autoCheckOut, language);
        }

        public DataSet ReadLookupTablesMultiLangByUids(Guid[] ltUidList, bool autoCheckOut)
        {
            return _psiContext.LookupTable.ReadLookupTablesMultiLangByUids(ltUidList, autoCheckOut);
        }

        public void CreateLookupTables(DataSet ltds, bool validateOnly, bool autoCheckIn)
        {
            _psiContext.LookupTable.CreateLookupTables((LookupTableDataSet)ltds, validateOnly, autoCheckIn);
        }

        public void UpdateLookupTables(DataSet ltds, bool validateOnly, bool autoCheckIn, int language)
        {
            _psiContext.LookupTable.UpdateLookupTables((LookupTableDataSet)ltds, validateOnly, autoCheckIn, language);
        }
    }
}
