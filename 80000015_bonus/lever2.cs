namespace Maple2.Trigger._80000015_bonus {
    public static class _lever2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7102}, arg2: false);
                context.SetInteractObject(interactIds: new []{10001315}, state: 1);
                context.SetMesh(triggerIds: new []{3006, 3007, 3008, 3009, 3010, 3011}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State안내(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001315}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$80000015_bonus__lever2__0$", duration: 2000, boxId: 102);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001315}, arg2: 0)) {
                    return new State문열림(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SpawnNpcRange(rangeId: new []{2002}, isAutoTargeting: false, score: 1500);
                context.SetMesh(triggerIds: new []{3006, 3007, 3008, 3009, 3010, 3011}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999101, key: "Dead_B", value: 1);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetSkill(triggerIds: new []{7102}, arg2: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
