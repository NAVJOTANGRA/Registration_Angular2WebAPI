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
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
require("rxjs/add/operator/do");
var CountryService = /** @class */ (function () {
    function CountryService(_http) {
        this._http = _http;
        this.localHostUrl = 'http://localhost:53915/';
        this._CoutryUrl = this.localHostUrl + 'api/ComapnyAndProduct/GetCountryList';
        this._StateUrl = this.localHostUrl + 'api/ComapnyAndProduct/GetStateList';
        this._CityUrl = this.localHostUrl + 'api/ComapnyAndProduct/GetCityList';
        this._saveData = this.localHostUrl + 'api/ComapnyAndProduct/SaveRegistrationForm';
    }
    //Bind Country Bind
    CountryService.prototype.getCountry = function () {
        return this._http.get(this._CoutryUrl)
            .map(function (response) { return response.json(); });
    };
    //Bind State Bind
    CountryService.prototype.getState = function () {
        return this._http.get(this._StateUrl)
            .map(function (response) { return response.json(); });
    };
    //Bind City Bind
    CountryService.prototype.getCity = function () {
        return this._http.get(this._CityUrl)
            .map(function (response) { return response.json(); });
    };
    //Save Data in database(sqlServer)
    CountryService.prototype.saveData = function (objSearch) {
        return this._http.post(this._saveData, objSearch)
            .map(function (response) { return response.json(); });
    };
    CountryService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.Http])
    ], CountryService);
    return CountryService;
}());
exports.CountryService = CountryService;
//# sourceMappingURL=CountryService.js.map