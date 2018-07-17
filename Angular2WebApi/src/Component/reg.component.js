"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var CountryService_1 = require("./CountryService");
require("rxjs/add/operator/map");
var RegistrationComponent = /** @class */ (function () {
    function RegistrationComponent(ServiceObject) {
        this.ServiceObject = ServiceObject;
        this.Title = 'Registration';
        this.myRadio = 'true';
        this.Error_msg = "Please enter name";
        this.istrue = 'true';
        console.log("Constructor Call");
    }
    RegistrationComponent.prototype.ngOnInit = function () {
        var _this = this;
        var param;
        console.log("ngonint Call");
        //Bind Country Bind
        this.ServiceObject.getCountry()
            .subscribe(function (response) { return (_this.Country) = response; });
        //Bind State Bind
        this.ServiceObject.getState()
            .subscribe(function (response) { return (_this.State) = response; });
        //Bind City Bind
        this.ServiceObject.getCity()
            .subscribe(function (data) { return (_this.City) = data; });
        console.log(this.City);
    };
    //On Submit button
    RegistrationComponent.prototype.fnSubmit = function () {
        // this.param = 'asd';
        //this.param = {
        //    objsearch: [{ "Key": "FirstName", "value": this.firstName },
        //        { "Key": "MiddleName", "value": this.middleName },
        //        { "Key": "fatherName ", "value": this.fatherName },
        //        { "Key": "motherName", "value": this.motherName },
        //        { "Key": "_UId", "value": this._UId },
        //        { "Key": "Country", "value": this.ddlcountry },    
        //        { "Key": "State", "value": this.ddlState },    
        //        { "Key": "City", "value": this.ddlCity },    
        //    ]
        //}
        var _this = this;
        this.objsearch = [{ "Key": "FirstName", "value": this.firstName },
            { "Key": "MiddleName", "value": this.middleName },
            { "Key": "fatherName ", "value": this.fatherName },
            { "Key": "motherName", "value": this.motherName },
            { "Key": "_UId", "value": this._UId },
            { "Key": "Country", "value": this.ddlcountry },
            { "Key": "State", "value": this.ddlState },
            { "Key": "City", "value": this.ddlCity },
            { "Key": "City", "value": this.myRadio },
        ];
        this.objsearch = {
            firstName: this.firstName,
            middleName: this.middleName,
            fatherName: this.fatherName,
            motherName: this.motherName,
            _Uid: this._UId,
            country: this.ddlcountry,
            state: this.ddlState,
            city: this.ddlCity,
            gender: this.myRadio
        };
        this.ServiceObject.saveData((this.objsearch))
            .subscribe(function (response) { return (_this._param) = response; });
        console.log("result is");
        console.log(this._param);
    };
    RegistrationComponent = __decorate([
        core_1.Component({
            selector: 'reg-form',
            templateUrl: 'HTMLPages/reg.component.html',
            styleUrls: ['CSS/reg.component.css'],
            providers: [CountryService_1.CountryService]
        }),
        __metadata("design:paramtypes", [CountryService_1.CountryService])
    ], RegistrationComponent);
    return RegistrationComponent;
}());
exports.RegistrationComponent = RegistrationComponent;
//# sourceMappingURL=reg.component.js.map