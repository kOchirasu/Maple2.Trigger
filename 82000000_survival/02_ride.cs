namespace Maple2.Trigger._82000000_survival {
    public static class _02_ride {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7100, 7200, 7300, 7400, 7500, 7600, 7700, 7800, 5100, 5200, 5300, 5400, 5500, 5600, 5700, 5800, 6100, 6200, 6300, 6400, 6500, 6600, 6700, 6800}, visible: false);
                context.SetUserValue(key: "SetRide", value: 0);
                context.SetUserValue(key: "StartPatrol", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SetRide") == 1) {
                    return new StateRide01_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 2) {
                    return new StateRide02_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 3) {
                    return new StateRide03_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 4) {
                    return new StateRide04_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 5) {
                    return new StateRide05_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 6) {
                    return new StateRide06_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 7) {
                    return new StateRide07_Ready(context);
                }

                if (context.GetUserValue(key: "SetRide") == 8) {
                    return new StateRide08_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide01_Ready : TriggerState {
            internal StateRide01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7100}, visible: true);
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_01");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide01_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide01_StartPatrolDelay : TriggerState {
            internal StateRide01_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5100}, visible: true);
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_111");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide01_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide01_StartPatrol : TriggerState {
            internal StateRide01_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{110}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_110");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{110});
                context.SetEffect(triggerIds: new []{6100}, visible: true);
            }
        }

        private class StateRide02_Ready : TriggerState {
            internal StateRide02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7200}, visible: true);
                context.CreateMonster(spawnIds: new []{120}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_02");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide02_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide02_StartPatrolDelay : TriggerState {
            internal StateRide02_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5200}, visible: true);
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_121");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide02_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide02_StartPatrol : TriggerState {
            internal StateRide02_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{120}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 120, patrolName: "MS2PatrolData_120");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{120});
                context.SetEffect(triggerIds: new []{6200}, visible: true);
            }
        }

        private class StateRide03_Ready : TriggerState {
            internal StateRide03_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7300}, visible: true);
                context.CreateMonster(spawnIds: new []{130}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_03");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide03_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide03_StartPatrolDelay : TriggerState {
            internal StateRide03_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: true);
                context.MoveNpc(spawnId: 130, patrolName: "MS2PatrolData_131");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide03_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide03_StartPatrol : TriggerState {
            internal StateRide03_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{130}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 130, patrolName: "MS2PatrolData_130");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{130});
                context.SetEffect(triggerIds: new []{6300}, visible: true);
            }
        }

        private class StateRide04_Ready : TriggerState {
            internal StateRide04_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7400}, visible: true);
                context.CreateMonster(spawnIds: new []{140}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_04");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide04_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide04_StartPatrolDelay : TriggerState {
            internal StateRide04_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400}, visible: true);
                context.MoveNpc(spawnId: 140, patrolName: "MS2PatrolData_141");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide04_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide04_StartPatrol : TriggerState {
            internal StateRide04_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{140}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 140, patrolName: "MS2PatrolData_140");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{140});
                context.SetEffect(triggerIds: new []{6400}, visible: true);
            }
        }

        private class StateRide05_Ready : TriggerState {
            internal StateRide05_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7500}, visible: true);
                context.CreateMonster(spawnIds: new []{150}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_05");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide05_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide05_StartPatrolDelay : TriggerState {
            internal StateRide05_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5500}, visible: true);
                context.MoveNpc(spawnId: 150, patrolName: "MS2PatrolData_151");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide05_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide05_StartPatrol : TriggerState {
            internal StateRide05_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{150}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 150, patrolName: "MS2PatrolData_150");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{150});
                context.SetEffect(triggerIds: new []{6500}, visible: true);
            }
        }

        private class StateRide06_Ready : TriggerState {
            internal StateRide06_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7600}, visible: true);
                context.CreateMonster(spawnIds: new []{160}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_06");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide06_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide06_StartPatrolDelay : TriggerState {
            internal StateRide06_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5600}, visible: true);
                context.MoveNpc(spawnId: 160, patrolName: "MS2PatrolData_161");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide06_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide06_StartPatrol : TriggerState {
            internal StateRide06_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{160}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 160, patrolName: "MS2PatrolData_160");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{160});
                context.SetEffect(triggerIds: new []{6600}, visible: true);
            }
        }

        private class StateRide07_Ready : TriggerState {
            internal StateRide07_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7700}, visible: true);
                context.CreateMonster(spawnIds: new []{170}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_07");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide07_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide07_StartPatrolDelay : TriggerState {
            internal StateRide07_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5700}, visible: true);
                context.MoveNpc(spawnId: 170, patrolName: "MS2PatrolData_171");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide07_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide07_StartPatrol : TriggerState {
            internal StateRide07_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{170}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 170, patrolName: "MS2PatrolData_170");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{170});
                context.SetEffect(triggerIds: new []{6700}, visible: true);
            }
        }

        private class StateRide08_Ready : TriggerState {
            internal StateRide08_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7800}, visible: true);
                context.CreateMonster(spawnIds: new []{180}, arg2: false);
                context.WriteLog(logName: "Survival", @event: "bus_08");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StartPatrol") == 1) {
                    return new StateRide08_StartPatrolDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide08_StartPatrolDelay : TriggerState {
            internal StateRide08_StartPatrolDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5800}, visible: true);
                context.MoveNpc(spawnId: 180, patrolName: "MS2PatrolData_181");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRide08_StartPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRide08_StartPatrol : TriggerState {
            internal StateRide08_StartPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{180}, skillId: 70001081, level: 1, arg4: true, arg5: false);
                context.MoveNpc(spawnId: 180, patrolName: "MS2PatrolData_180");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 32000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{180});
                context.SetEffect(triggerIds: new []{6800}, visible: true);
            }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "bus_end");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
