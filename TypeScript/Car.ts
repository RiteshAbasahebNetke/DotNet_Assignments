import {HandBrake} from "./HandBrakeModule";
import {Engine} from "./EngineModule";
import {Accelerator} from "./AcceleratorModule";

export class Car
{
    private break:HandBrake;
    private engine:Engine;
    private Accelerator:Accelerator;

    constructor()
    {
        this.break=new HandBrake();
        this.engine=new Engine();
        this.Accelerator=new Accelerator();
    }

    run():void
    {
        this.break.release();
        this.engine.release();
        this.Accelerator.release();
        console.log('Car is running...!');
    }
}

var v=new Car();
v.run();