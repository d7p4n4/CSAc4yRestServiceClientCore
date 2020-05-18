using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace CSAc4yRestServiceClientCore
{
    public class EFCSTPC4Core3RESTServiceClient
    {
        public GetListResponse GetList(GetListRequest request)
        {
            GetListResponse response = new GetListResponse();

            try
            {
                Ac4yRestServiceClient ac4yRestServiceClient = new Ac4yRestServiceClient("https://ac4yservice.sycompla.hu");

                response.Result.Message = ac4yRestServiceClient.GET("/odata/ac4yodata");

                response.Result = new Ac4yProcessResult() { Code = Ac4yProcessResult.SUCCESS };
                
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = Ac4yProcessResult.FAIL, Message = exception.Message, Description = exception.StackTrace });
            }

            return response;

         } // GetList
    /*
        public GetByIdResponse GetById(GetByIdRequest request)
        {


        } // GetById

        public GetByGuidResponse GetByGuid(GetByGuidRequest request)
        {


        } // GetByGuid

        public IsExistByIdResponse IsExistById(IsExistByIdRequest request)
        {

        } // IsExistById

        public IsExistByGuidResponse IsExistByGuid(IsExistByGuidRequest request)
        {


        } // IsExistByGuid

        public UpdateByIdResponse UpdateById(UpdateByIdRequest request)
        {


        } // UpdateById

        public UpdateByGuidResponse UpdateByGuid(UpdateByGuidRequest request)
        {

        } // UpdateByGuid

        public InsertResponse Insert(InsertRequest request)
        {


        } // Insert

        public SetByGuidResponse SetByGuid(SetByGuidRequest request)
        {


        } // SetByGuid

        public DeleteByIdResponse DeleteById(DeleteByIdRequest request)
        {

        }*/


    } // Ac4yPersistentChildEFService

} // EFService
