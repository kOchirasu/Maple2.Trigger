namespace Maple2.Trigger._02000304_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: false, arg3: "Closed_A");
                context.SetActor(arg1: 202, arg2: false, arg3: "Closed_A");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_functobj_monitor_C01_On");
                context.SetEffect(arg1: new[] {602, 603}, arg2: false);
                context.SetPortal(portalId: 98, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 99, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {10000646}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    context.CreateMonster(arg1: new[] {2001}, arg2: false);
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCamera이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동Wait : TriggerState {
            internal StateCamera이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateBattleStartWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStartWait : TriggerState {
            internal StateBattleStartWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003041, textId: 20003041, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2001, script: "$02000304_BF__MAIN__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.SetActor(arg1: 203, arg2: false, arg3: "sf_functobj_monitor_C01_On");
                    context.SetInteractObject(arg1: new[] {10000646}, arg2: 1);
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.ShowGuideSummary(entityId: 20003003, textId: 20003003);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000646}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003003);
                    context.SetEffect(arg1: new[] {603}, arg2: false);
                    context.SetEffect(arg1: new[] {602}, arg2: true);
                    context.SetAchievement(arg1: 999, arg2: "trigger", arg3: "ClearTimehole");
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션Success : TriggerState {
            internal State미션Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed_A");
                context.SetActor(arg1: 202, arg2: true, arg3: "Closed_A");
                context.SetPortal(portalId: 99, visible: false, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 98, visible: false, enabled: true, minimapVisible: true);
                context.SetTimer(id: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}