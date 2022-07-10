namespace Maple2.Trigger._02000037_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000931}, state: 2);
                context.SetMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4040, 4041, 4042, 4043, 4044, 4045, 4046}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4050}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State난이도체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonLevel() == 2) {
                    return new State레이드(context);
                }

                if (context.GetDungeonLevel() == 3) {
                    return new State카오스레이드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이드 : TriggerState {
            internal State레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000})) {
                    return new StateCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카오스레이드 : TriggerState {
            internal State카오스레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematicDelay : TriggerState {
            internal StateCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000931}, state: 1);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000931})) {
                    return new State사념Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사념Spawn01 : TriggerState {
            internal State사념Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4050}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: true);
                context.SetRandomMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009}, visible: true, meshCount: 10, arg4: 0, delay: 50);
                context.SetRandomMesh(triggerIds: new []{4040, 4041, 4042, 4043, 4044, 4045, 4046}, visible: true, meshCount: 7, arg4: 400, delay: 50);
                context.SetRandomMesh(triggerIds: new []{4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034}, visible: true, meshCount: 15, arg4: 800, delay: 50);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
