using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100002_qd {
    public static class _summon {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602, 603}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SummonSister") == 1) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State소환(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuest소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", script: "$02000392_BF__SUMMON__0$", align: Align.Left, duration: 2000);
                context.SetSkip(state: new State죽음Wait(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraReset(interpolationTime: 1.0f);
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    return new State죽음Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest소환 : TriggerState {
            internal StateQuest소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.CreateMonster(arg1: new[] {2102}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", script: "$02000392_BF__SUMMON__0$", align: Align.Left, duration: 2000);
                context.SetSkip(state: new StateQuest죽음Wait(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraReset(interpolationTime: 1.0f);
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    return new StateQuest죽음Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest죽음Wait : TriggerState {
            internal StateQuest죽음Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2101})) {
                    return new StateQuest셀린Dead(context);
                }

                if (context.MonsterDead(arg1: new[] {2102})) {
                    return new StateQuest피리스Dead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest셀린Dead : TriggerState {
            internal StateQuest셀린Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2102, script: "$02000392_BF__SUMMON__1$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2102}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest피리스Dead : TriggerState {
            internal StateQuest피리스Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2101, script: "$02000392_BF__SUMMON__2$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2101}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죽음Wait : TriggerState {
            internal State죽음Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    return new State셀린Dead(context);
                }

                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new State피리스Dead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State셀린Dead : TriggerState {
            internal State셀린Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2002, script: "$02000392_BF__SUMMON__1$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2002}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피리스Dead : TriggerState {
            internal State피리스Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "BigSisterFirst");
                context.SetConversation(arg1: 1, arg2: 2001, script: "$02000392_BF__SUMMON__2$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2001}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}