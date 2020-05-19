using Modul.Final.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace CSAc4yRestServiceClientCore
{
    public class CSEFTPC4Core3RESTServiceClient
    {

        public ODataGetResponse GetList(GetListRequest request)
        {
            Ac4yRestServiceClient ac4yRestServiceClient = new Ac4yRestServiceClient("https://ac4yrestservice.sycompla.hu/odata/ac4yodata");

            string json = ac4yRestServiceClient.GET("");

            return JsonConvert.DeserializeObject<ODataGetResponse>(json);


        } // GetList
    
        public GetByIdResponse GetById(GetByIdRequest request)
        {
             Ac4yRestServiceClient ac4yRestServiceClient = new Ac4yRestServiceClient("https://ac4yrestservice.sycompla.hu");

            string json = ac4yRestServiceClient.GET("/ac4ypersistentchild/getbyid/", "{\n\t\"Id\": " + request.Id + "\n\t}");

            return JsonConvert.DeserializeObject<GetByIdResponse>(json);

        } // GetById
        /*
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


    }
}
