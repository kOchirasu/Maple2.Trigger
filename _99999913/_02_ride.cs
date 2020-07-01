namespace Maple2.Trigger._99999913 {
    public static class _02_ride {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SetRide", value: 0);
                context.SetUserValue(key: "StartPatrol", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SetRide") == 1) {
                    context.State = new StateRide01_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 2) {
                    context.State = new StateRide02_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 3) {
                    context.State = new StateRide03_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 4) {
                    context.State = new StateRide04_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 5) {
                    context.State = new StateRide05_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 6) {
                    context.State = new StateRide06_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 7) {
                    context.State = new StateRide07_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "SetRide") == 8) {
                    context.State = new StateRide08_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide01_Ready : TriggerState {
            internal StateRide01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_01");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide01_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide01_StartPatrolDelay : TriggerState {
            internal StateRide01_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide01_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide01_StartPatrol : TriggerState {
            internal StateRide01_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_110");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide02_Ready : TriggerState {
            internal StateRide02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {120}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_02");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide02_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide02_StartPatrolDelay : TriggerState {
            internal StateRide02_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide02_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide02_StartPatrol : TriggerState {
            internal StateRide02_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 120, arg2: "MS2PatrolData_120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide03_Ready : TriggerState {
            internal StateRide03_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {130}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_03");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide03_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide03_StartPatrolDelay : TriggerState {
            internal StateRide03_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide03_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide03_StartPatrol : TriggerState {
            internal StateRide03_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 130, arg2: "MS2PatrolData_130");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide04_Ready : TriggerState {
            internal StateRide04_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {140}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_04");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide04_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide04_StartPatrolDelay : TriggerState {
            internal StateRide04_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide04_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide04_StartPatrol : TriggerState {
            internal StateRide04_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 140, arg2: "MS2PatrolData_140");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide05_Ready : TriggerState {
            internal StateRide05_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {150}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_05");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide05_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide05_StartPatrolDelay : TriggerState {
            internal StateRide05_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide05_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide05_StartPatrol : TriggerState {
            internal StateRide05_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 150, arg2: "MS2PatrolData_150");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide06_Ready : TriggerState {
            internal StateRide06_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {160}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_06");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide06_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide06_StartPatrolDelay : TriggerState {
            internal StateRide06_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide06_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide06_StartPatrol : TriggerState {
            internal StateRide06_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 160, arg2: "MS2PatrolData_160");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide07_Ready : TriggerState {
            internal StateRide07_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {170}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_07");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide07_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide07_StartPatrolDelay : TriggerState {
            internal StateRide07_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide07_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide07_StartPatrol : TriggerState {
            internal StateRide07_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 170, arg2: "MS2PatrolData_170");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide08_Ready : TriggerState {
            internal StateRide08_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {180}, arg2: false);
                context.WriteLog(arg1: "Survival", arg3: "bus_08");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    context.State = new StateRide08_StartPatrolDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide08_StartPatrolDelay : TriggerState {
            internal StateRide08_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRide08_StartPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRide08_StartPatrol : TriggerState {
            internal StateRide08_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 180, arg2: "MS2PatrolData_180");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 36000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {110, 120, 130, 140, 150, 160, 170, 180});
                context.WriteLog(arg1: "Survival", arg3: "bus_end");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}