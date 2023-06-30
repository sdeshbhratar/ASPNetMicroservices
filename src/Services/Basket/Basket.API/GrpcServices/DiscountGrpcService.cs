using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountprotoservice;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountprotoservice)
        {
            _discountprotoservice = discountprotoservice ?? throw new ArgumentNullException(nameof(discountprotoservice));
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };

            return await _discountprotoservice.GetDiscountAsync(discountRequest);
        }
    }
}
