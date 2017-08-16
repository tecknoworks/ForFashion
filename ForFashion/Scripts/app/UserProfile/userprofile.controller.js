var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var UserProfileModel = (function () {
    function UserProfileModel() {
    }
    ;
    return UserProfileModel;
}());
var UserProfileController = (function (_super) {
    __extends(UserProfileController, _super);
    function UserProfileController($http) {
        _super.call(this);
        this.httpService = $http;
        this.UserProfileModel = new UserProfileModel();
        this.getData();
    }
    UserProfileController.prototype.getData = function () {
        var _this = this;
        this.httpService({
            method: 'GET',
            url: 'api/UserDetails',
            headers: {
                'Authorization': 'Bearer ' + this.user.token
            },
        }).then(function (response) {
            console.log(response.data);
            _this.UserProfileModel.FirstName = response.data.FirstName;
            _this.UserProfileModel.LastName = response.data.LastName;
            _this.UserProfileModel.City = response.data.City;
            _this.UserProfileModel.Address = response.data.Address;
            _this.UserProfileModel.PhoneNumber = response.data.PhoneNumber;
        }, function (response) {
        });
    };
    UserProfileController.prototype.postData = function () {
        var _this = this;
        var self = this;
        var req = {
            method: 'POST',
            url: 'api/UserDetails',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Bearer ' + this.user.token
            },
            data: {
                "FirstName": this.UserProfileModel.FirstName,
                "LastName": this.UserProfileModel.LastName,
                "City": this.UserProfileModel.City,
                "Address": this.UserProfileModel.Address,
                "PhoneNumber": this.UserProfileModel.PhoneNumber
            }
        };
        this.httpService(req).then(function (response) {
            _this.UserProfileModel.Error = "";
            console.log(response.data);
        }, function (error) {
            console.log('error');
        });
    };
    return UserProfileController;
}(BaseController));
//# sourceMappingURL=userprofile.controller.js.map