"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Car = void 0;
var HandBrakeModule_1 = require("./HandBrakeModule");
var EngineModule_1 = require("./EngineModule");
var AcceleratorModule_1 = require("./AcceleratorModule");
var Car = /** @class */ (function () {
    function Car() {
        this.break = new HandBrakeModule_1.HandBrake();
        this.engine = new EngineModule_1.Engine();
        this.Accelerator = new AcceleratorModule_1.Accelerator();
    }
    Car.prototype.run = function () {
        this.break.release();
        this.engine.release();
        this.Accelerator.release();
        console.log('Car is running...!');
    };
    return Car;
}());
exports.Car = Car;
var v = new Car();
v.run();
