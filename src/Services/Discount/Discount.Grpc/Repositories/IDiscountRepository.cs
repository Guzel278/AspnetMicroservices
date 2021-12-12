using Discount.Grpc.Entities;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
        Task UpdateDiscount(CouponModel coupon);
        Task CreateDiscount(CouponModel coupon);
    }
}
