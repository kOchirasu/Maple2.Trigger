using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000281_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301, 302}, visible: true, arg3: 0, arg4: 0);
                context.SetInteractObject(interactIds: new []{10000414}, state: 0);
                context.SetLadder(triggerId: 321, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 322, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 323, visible: false, animationEffect: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
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

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000414}, state: 1);
                context.CameraSelect(triggerId: 3001, enabled: true);
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCameraWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateCameraWait : TriggerState {
            internal StateCameraWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002810, textId: 20002810, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 3002, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.CameraSelect(triggerId: 3002, enabled: false);
            }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301, 302}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000414}, arg2: 0)) {
                    return new StateBoss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss : TriggerState {
            internal StateBoss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
                context.ShowGuideSummary(entityId: 20002816, textId: 20002816, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.SetLadder(triggerId: 321, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 322, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 323, visible: true, animationEffect: true);
                    context.SetPortal(portalId: 2, visible: false, enabled: true, minimapVisible: true);
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
