namespace Pharm2U.Models
{
    public enum OrderStatus
    {
        STATUS_UNKNOWN                  = -1,
        STATUS_NEWORDER                 = 0,
        STATUS_READY_FOR_PAYMENT        = 10,
        STATUS_PAYMENT_RECEIVED         = 20,
        STATUS_PACKAGING                = 30,
        STATUS_READY_FOR_DELIVERY       = 40,
        STATUS_OUT_FOR_DELIVERY         = 50,
        STATUS_RETURN_NOT_DELIVERED     = 60,
        STATUS_COMPLETED                = 70,
    }
}
