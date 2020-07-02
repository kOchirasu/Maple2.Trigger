namespace Maple2.Trigger._52000084_qd {
    public static class _1122330_findway {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017}, arg2: false);
                context.DestroyMonster(arg1: new[] {101});
                context.SetActor(arg1: 4000, arg2: true, arg3: "ic_fi_funct_icedoor_A01_off");
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "BossRoomPortal01", value: 0);
                context.SetUserValue(key: "BossRoomPortal02", value: 0);
                context.SetUserValue(key: "BossRoomPortal03", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateQuestcheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestcheck : TriggerState {
            internal StateQuestcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100280}, arg3: new byte[] {1})) {
                    return new StateDungeonStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100280}, arg3: new byte[] {2})) {
                    return new StateTeleport52100085(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100280}, arg3: new byte[] {3})) {
                    return new StateTeleport52100085(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01 : TriggerState {
            internal StateNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", msg: "$52000084_QD__1122330_FINDWAY__0$", align: "right", duration: 4000);
                context.SetSkip(arg1: "NpcTalk01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNpcTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01Skip : TriggerState {
            internal StateNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateNpcTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk02 : TriggerState {
            internal StateNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003068, illustId: "Seolnunyi_normal", msg: "$52000084_QD__1122330_FINDWAY__1$", align: "right", duration: 5000);
                context.SetSkip(arg1: "NpcTalk02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDoorOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk02Skip : TriggerState {
            internal StateNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateDoorOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen01 : TriggerState {
            internal StateDoorOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "ic_fi_funct_icedoor_A01_on");
                context.SetMesh(arg1: new[] {3000, 3001, 3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraReset01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraReset01 : TriggerState {
            internal StateCameraReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20038101, textId: 20038101, duration: 4000);
                context.SetActor(arg1: 4000, arg2: false, arg3: "ic_fi_funct_icedoor_A01_on");
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129}, arg2: false, arg3: 2000, arg4: 70, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossRoomPortal01") == 1) {
                    return new StateBossRoomPortal01(context);
                }

                if (context.GetUserValue(key: "BossRoomPortal02") == 1) {
                    return new StateBossRoomPortal02(context);
                }

                if (context.GetUserValue(key: "BossRoomPortal03") == 1) {
                    return new StateBossRoomPortal03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossRoomPortal01 : TriggerState {
            internal StateBossRoomPortal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossRoomPortal02 : TriggerState {
            internal StateBossRoomPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossRoomPortal03 : TriggerState {
            internal StateBossRoomPortal03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleport52100085 : TriggerState {
            internal StateTeleport52100085(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000085, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}