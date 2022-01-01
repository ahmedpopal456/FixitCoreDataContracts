using System.Collections.Generic;
using Fixit.Core.DataContracts.Files.Files;

namespace Fixit.Core.DataContracts.Files.Comparers
{
  public class FileTagDtoComparer : IEqualityComparer<FileTagDto>
  {
    public FileTagDtoComparer()
    {

    }

    public bool Equals(FileTagDto x, FileTagDto y)
    {
      bool result = false; 

      if (x.Name == y.Name)
      {
        result = true; 
      }

      return result;
    }

    public int GetHashCode(FileTagDto obj)
    {
      return obj.GetHashCode();
    }
  }
}
