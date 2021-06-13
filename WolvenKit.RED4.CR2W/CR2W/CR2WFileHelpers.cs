using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED4.CR2W
{
    public static class CR2WFileHelper
    {
        #region Methods

        public static CR2WFile FromCResource(this CR2WFile file, CResource res, bool cooked = false)
        {
            // checks to see if the variable from which the chunk is built is properly constructed
            if (res == null || res.REDName != res.REDType || res.ParentVar != null)
                return null;

            file.CreateChunk(res);

            return file;
        }

        #endregion Methods
    }
}
