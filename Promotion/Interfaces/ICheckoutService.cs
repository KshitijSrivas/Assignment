namespace Promotion
{
    /// <summary>
    /// Defines the <see cref="ICheckoutService" />.
    /// </summary>
    interface ICheckoutService
    {
        /// <summary>
        /// The CalculateTotalAmount.
        /// </summary>
        /// <returns>The <see cref="double"/>.</returns>
        double CalculateTotalAmount();
    }
}
