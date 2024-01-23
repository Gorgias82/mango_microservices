﻿using Mango.web.Models;
using Mango.web.Service.IService;
using Mango.web.Utility;
using Mango.Web.Models;
using Mngo.Web.Models;

namespace Mango.web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiTye.POST,
                Data = couponDto,
                Url = SD.CouponApiBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiTye.DELETE,
                Url = SD.CouponApiBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiTye.GET,
                Url=SD.CouponApiBase+"/api/coupon"
            }) ;
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiTye.GET,
                Url = SD.CouponApiBase + "/api/coupon/GetByCode/"+couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiTye.GET,
                Url = SD.CouponApiBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiTye.PUT,
                Data = couponDto,
                Url = SD.CouponApiBase + "/api/coupon"
            });
        }
    }
}
