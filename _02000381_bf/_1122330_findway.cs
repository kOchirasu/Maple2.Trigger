using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000381_bf {
    public static class _1122330_findway {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8000}, arg2: false);
                context.SetSkill(arg1: new int[] {8001}, arg2: false);
                context.SetSkill(arg1: new int[] {8002}, arg2: false);
                context.SetSkill(arg1: new int[] {8003}, arg2: false);
                context.SetSkill(arg1: new int[] {8004}, arg2: false);
                context.SetSkill(arg1: new int[] {8005}, arg2: false);
                context.SetSkill(arg1: new int[] {8006}, arg2: false);
                context.SetSkill(arg1: new int[] {8007}, arg2: false);
                context.SetSkill(arg1: new int[] {8008}, arg2: false);
                context.SetSkill(arg1: new int[] {8009}, arg2: false);
                context.SetSkill(arg1: new int[] {8010}, arg2: false);
                context.SetSkill(arg1: new int[] {8011}, arg2: false);
                context.SetSkill(arg1: new int[] {8012}, arg2: false);
                context.SetSkill(arg1: new int[] {8013}, arg2: false);
                context.SetSkill(arg1: new int[] {8014}, arg2: false);
                context.SetSkill(arg1: new int[] {8015}, arg2: false);
                context.SetSkill(arg1: new int[] {8016}, arg2: false);
                context.SetSkill(arg1: new int[] {8017}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
                context.SetActor(arg1: 4000, arg2: true, arg3: "ic_fi_funct_icedoor_A01_off");
                context.SetMesh(arg1: new int[] {3000, 3001, 3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "BossRoomPortal01", value: 0);
                context.SetUserValue(key: "BossRoomPortal02", value: 0);
                context.SetUserValue(key: "BossRoomPortal03", value: 0);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNpcPatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcPatrol01 : TriggerState {
            internal StateNpcPatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_200");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraSet01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraSet01 : TriggerState {
            internal StateCameraSet01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNpcTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01 : TriggerState {
            internal StateNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003068, arg3: "$02000381_BF__1122330_FINDWAY__0$", arg4: 5);
                context.SetSkip(arg1: "NpcTalk01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNpcTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01Skip : TriggerState {
            internal StateNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDoorOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen01 : TriggerState {
            internal StateDoorOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "ic_fi_funct_icedoor_A01_on");
                context.SetMesh(arg1: new int[] {3000, 3001, 3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraReset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraReset01 : TriggerState {
            internal StateCameraReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateNpcChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20038101, textID: 20038101, duration: 4000);
                context.SetActor(arg1: 4000, arg2: false, arg3: "ic_fi_funct_icedoor_A01_on");
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129
                    }, arg2: false, arg3: 2000, arg4: 70, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserValue(key: "BossRoomPortal01", value: 1)) {
                    context.State = new StateBossRoomPortal01(context);
                    return;
                }

                if (context.UserValue(key: "BossRoomPortal02", value: 1)) {
                    context.State = new StateBossRoomPortal02(context);
                    return;
                }

                if (context.UserValue(key: "BossRoomPortal03", value: 1)) {
                    context.State = new StateBossRoomPortal03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossRoomPortal01 : TriggerState {
            internal StateBossRoomPortal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossRoomPortal02 : TriggerState {
            internal StateBossRoomPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossRoomPortal03 : TriggerState {
            internal StateBossRoomPortal03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8000}, arg2: true);
                context.SetSkill(arg1: new int[] {8001}, arg2: true);
                context.SetSkill(arg1: new int[] {8002}, arg2: true);
                context.SetSkill(arg1: new int[] {8003}, arg2: true);
                context.SetSkill(arg1: new int[] {8004}, arg2: true);
                context.SetSkill(arg1: new int[] {8005}, arg2: true);
                context.SetSkill(arg1: new int[] {8006}, arg2: true);
                context.SetSkill(arg1: new int[] {8007}, arg2: true);
                context.SetSkill(arg1: new int[] {8008}, arg2: true);
                context.SetSkill(arg1: new int[] {8009}, arg2: true);
                context.SetSkill(arg1: new int[] {8010}, arg2: true);
                context.SetSkill(arg1: new int[] {8011}, arg2: true);
                context.SetSkill(arg1: new int[] {8012}, arg2: true);
                context.SetSkill(arg1: new int[] {8013}, arg2: true);
                context.SetSkill(arg1: new int[] {8014}, arg2: true);
                context.SetSkill(arg1: new int[] {8015}, arg2: true);
                context.SetSkill(arg1: new int[] {8016}, arg2: true);
                context.SetSkill(arg1: new int[] {8017}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}