namespace Domain.Models;

/// <summary>
/// Represents the status of an order in the e-commerce system.
/// </summary>
[Flags]
public enum OrderStatus
{
    /// <summary>
    /// Indicates that the order status is not set or is unknown.
    /// </summary>
    None = 0,

    /// <summary>
    /// Indicates that the order has been approved and is ready for processing.
    /// </summary>
    Approved = 1,

    /// <summary>
    /// Indicates that the order is pending and awaiting further action or confirmation.
    /// </summary>
    Pending = 2,

    /// <summary>
    /// Indicates that the order has been shipped to the customer.
    /// </summary>
    Shipped = 4,

    /// <summary>
    /// Indicates that the order has been delivered to the customer.
    /// </summary>
    Delivered = 8,

    /// <summary>
    /// Indicates that the order has been cancelled and will not be processed further.
    /// </summary>
    Cancelled = 16,

    /// <summary>
    /// Indicates that the order has been returned by the customer.
    /// </summary>
    Returned = 32,

    /// <summary>
    /// Indicates that the order has been refunded to the customer.
    /// </summary>
    Refunded = 64,

    /// <summary>
    /// Indicates that the order is currently on hold and cannot be processed at this time.
    /// </summary>
    OnHold = 128,

    /// <summary>
    /// Indicates that the order is currently being processed and is not yet complete.
    /// </summary>
    Processing = 256,

    /// <summary>
    /// Indicates that the order has been completed successfully and all items have been delivered or fulfilled.
    /// </summary>
    Completed = 512,

    /// <summary>
    /// Indicates that the order has failed due to an error or issue during processing.
    /// </summary>
    Failed = 1024,

    /// <summary>
    /// Indicates that the order is awaiting payment from the customer before it can be processed further.
    /// </summary>
    AwaitingPayment = 2048,

    /// <summary>
    /// Indicates that the order is awaiting shipment, meaning it has been processed and is ready to be shipped to the customer.
    /// </summary>
    AwaitingShipment = 4096,

    /// <summary>
    /// Indicates that the order is awaiting fulfillment, meaning it is ready to be picked, packed, and shipped to the customer.
    /// </summary>
    AwaitingFulfillment = 8192,

    /// <summary>
    /// Indicates that the order is awaiting pickup by the customer or a delivery service.
    /// </summary>
    AwaitingPickup = 16384,

    /// <summary>
    /// Indicates that the order is awaiting confirmation from the customer or another party before proceeding with further actions.
    /// </summary>
    AwaitingConfirmation = 32768,

    /// <summary>
    /// Indicates that the order is awaiting review by a team member or manager before it can proceed to the next stage.
    /// </summary>
    AwaitingReview = 65536,

    /// <summary>
    /// Indicates that the order is awaiting action from the customer or another party before it can proceed to the next stage.
    /// </summary>
    AwaitingAction = 131072,

    /// <summary>
    /// Indicates that the order is awaiting a response from the customer or another party before it can proceed to the next stage.
    /// </summary>
    AwaitingResponse = 262144,

    /// <summary>
    /// Indicates that the order is awaiting approval from a manager or administrator before it can proceed to the next stage.
    /// </summary>
    AwaitingApproval = 524288,

    /// <summary>
    /// Indicates that the order is awaiting stock availability before it can be processed further.
    /// </summary>
    AwaitingStock = 1048576,

    /// <summary>
    /// Indicates that the order is awaiting supplier confirmation or action before it can proceed to the next stage.
    /// </summary>
    AwaitingSupplier = 2097152,
}
