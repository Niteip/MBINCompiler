using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x50FAD3F04610D74C, NameHash = 0x0C597628B65E70FD4)]
    public class GcAtlasSendMarkFeaturedBase : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x40)]
        /* 0x08 */ public String BaseID;
    }
}
