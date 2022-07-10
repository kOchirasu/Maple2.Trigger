namespace Maple2.Trigger._02000006_ad {
    public static class _01_followallice {
        public class StateWait00 : TriggerState {
            internal StateWait00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{51, 52, 53, 54});
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, visible: false);
                context.SetEffect(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, visible: false);
                context.SetLadder(triggerId: 151, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 152, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 153, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 154, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 155, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 156, visible: false, animationEffect: false);
                context.SetEffect(triggerIds: new []{219, 220, 221, 222, 223, 224}, visible: false);
                context.SetInteractObject(interactIds: new []{10000449}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000449}, arg2: 0)) {
                    return new StateWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{51}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{51})) {
                    return new StateSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster수명설정 : TriggerState {
            internal StateMonster수명설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup01 : TriggerState {
            internal StateSetup01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101}, visible: true);
                context.SetEffect(triggerIds: new []{201}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup02 : TriggerState {
            internal StateSetup02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{102}, visible: true);
                context.SetEffect(triggerIds: new []{202}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup03 : TriggerState {
            internal StateSetup03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{103}, visible: true);
                context.SetEffect(triggerIds: new []{203}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup04 : TriggerState {
            internal StateSetup04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{104}, visible: true);
                context.SetEffect(triggerIds: new []{204}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup05 : TriggerState {
            internal StateSetup05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{105}, visible: true);
                context.SetEffect(triggerIds: new []{205}, visible: true);
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{52}, arg2: true);
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, visible: false);
                context.SetEffect(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, visible: false);
                context.SetTimer(timerId: "2", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{52})) {
                    return new StateSetup06(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup06 : TriggerState {
            internal StateSetup06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{106}, visible: true);
                context.SetEffect(triggerIds: new []{206}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup07 : TriggerState {
            internal StateSetup07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{107}, visible: true);
                context.SetEffect(triggerIds: new []{207}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup08 : TriggerState {
            internal StateSetup08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{108}, visible: true);
                context.SetEffect(triggerIds: new []{208}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup09 : TriggerState {
            internal StateSetup09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{109}, visible: true);
                context.SetEffect(triggerIds: new []{209}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup10 : TriggerState {
            internal StateSetup10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{110}, visible: true);
                context.SetEffect(triggerIds: new []{210}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup11 : TriggerState {
            internal StateSetup11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{111}, visible: true);
                context.SetEffect(triggerIds: new []{211}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup12 : TriggerState {
            internal StateSetup12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{112}, visible: true);
                context.SetEffect(triggerIds: new []{212}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup13 : TriggerState {
            internal StateSetup13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{113}, visible: true);
                context.SetEffect(triggerIds: new []{213}, visible: true);
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait03 : TriggerState {
            internal StateWait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{53}, arg2: true);
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, visible: false);
                context.SetEffect(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, visible: false);
                context.SetTimer(timerId: "2", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{53})) {
                    return new StateSetup14(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup14 : TriggerState {
            internal StateSetup14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{114}, visible: true);
                context.SetEffect(triggerIds: new []{214}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup15 : TriggerState {
            internal StateSetup15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{115}, visible: true);
                context.SetEffect(triggerIds: new []{215}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup16 : TriggerState {
            internal StateSetup16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{116}, visible: true);
                context.SetEffect(triggerIds: new []{216}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup17 : TriggerState {
            internal StateSetup17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{117}, visible: true);
                context.SetEffect(triggerIds: new []{217}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSetup18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup18 : TriggerState {
            internal StateSetup18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{118}, visible: true);
                context.SetEffect(triggerIds: new []{218}, visible: true);
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait04 : TriggerState {
            internal StateWait04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{54}, arg2: true);
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118}, visible: false);
                context.SetEffect(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218}, visible: false);
                context.SetTimer(timerId: "2", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{54})) {
                    return new StateLadder(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder : TriggerState {
            internal StateLadder(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 151, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 152, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 153, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 154, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 155, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 156, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{219, 220, 221, 222, 223, 224}, visible: true);
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
