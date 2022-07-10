using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000194_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10001054, 10001055, 10001056, 10001057, 11000004}, state: 2);
                context.SetMesh(triggerIds: new []{3005, 3006, 3007, 3001, 3002, 3003, 3004, 3101, 3102, 3103, 3104, 3201, 3202, 3203, 3301, 3302, 3303, 3304}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeon시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeon시작 : TriggerState {
            internal StateDungeon시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20001941, textId: 20001941, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetInteractObject(interactIds: new []{10001054, 10001055, 10001056, 10001057}, state: 1);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 2000}, arg2: false);
                context.CameraSelect(triggerId: 301, enable: true);
                context.AddBuff(boxIds: new []{101}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.SetSkip(state: new StateStart(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 301, enable: false);
                context.SetMesh(triggerIds: new []{3005, 3006, 3007}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(boxId: 101, skillId: 70000107);
            }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20001942, textId: 20001942, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart2 : TriggerState {
            internal StateStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001054}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State오브젝트2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트2 : TriggerState {
            internal State오브젝트2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001055}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{3201, 3202, 3203}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State오브젝트3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트3 : TriggerState {
            internal State오브젝트3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001056}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State오브젝트4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트4 : TriggerState {
            internal State오브젝트4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001057}, arg2: 0)) {
                    context.ShowGuideSummary(entityId: 20001944, textId: 20001944, duration: 5000);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
