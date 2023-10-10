using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020061_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.EnableSpawnPointPc(spawnId: 2, enabled: false);
                context.EnableSpawnPointPc(spawnId: 3, enabled: false);
                context.EnableSpawnPointPc(spawnId: 4, enabled: false);
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.ResetTimer(timerId: "3");
                context.SetActor(triggerId: 1901, visible: true, initialSequence: "Idle_A");
                context.SetEffect(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, visible: true);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048}, visible: true);
                context.ShadowExpeditionCloseBossGauge();
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 0);
                context.SetUserValue(triggerId: 99990008, key: "BossPhase", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State유저Count(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Count : TriggerState {
            internal State유저Count(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    return new StateDelay(context);
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    return new State방폭(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9002, type: "trigger", code: "corps_battle");
                context.SetEventUI(arg1: 1, script: "$02020061_BF__MAIN__0$", duration: 5000);
                context.CameraSelect(triggerId: 999, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방폭 : TriggerState {
            internal State방폭(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020061_BF__MAIN__1$", duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State내보내기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State내보내기 : TriggerState {
            internal State내보내기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
                context.EnableSpawnPointPc(spawnId: 2, enabled: true);
                context.EnableSpawnPointPc(spawnId: 3, enabled: true);
                context.EnableSpawnPointPc(spawnId: 4, enabled: true);
                context.CameraReset(interpolationTime: 1f);
                context.SetEffect(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, visible: false);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048}, visible: false);
                context.SetEventUI(arg1: 0, script: "1,3");
                context.SetEventUI(arg1: 1, script: "$02020061_BF__MAIN__2$", duration: 5000);
                context.SetTimer(timerId: "1", seconds: 180, autoRemove: true, display: true, vOffset: 60);
                context.ShadowExpeditionOpenBossGauge(maxGaugePoint: 800);
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 1);
                context.SetActor(triggerId: 1901, visible: false, initialSequence: "Idle_A");
                context.CreateMonster(spawnIds: new []{701}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GaugeClear") == 1) {
                    return new State오브젝트Phase(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트Phase : TriggerState {
            internal State오브젝트Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000001);
                context.SetEventUI(arg1: 1, script: "$02020061_BF__MAIN__3$", duration: 5000);
                context.ShadowExpeditionCloseBossGauge();
                context.SetEventUI(arg1: 0, script: "2,3");
                context.ResetTimer(timerId: "1");
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 1);
                context.SetTimer(timerId: "2", seconds: 180, autoRemove: true, display: true, vOffset: 60);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectClear") == 1) {
                    return new StateBossPhase(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossPhase : TriggerState {
            internal StateBossPhase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000002);
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetEventUI(arg1: 1, script: "$02020061_BF__MAIN__4$", duration: 5000);
                context.ResetTimer(timerId: "2");
                context.SetEventUI(arg1: 0, script: "3,3");
                context.SetUserValue(triggerId: 99990008, key: "BossPhase", value: 1);
                context.SetTimer(timerId: "3", seconds: 180, autoRemove: true, display: true, vOffset: 60);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossClear") == 1) {
                    return new StateSuccess_세팅(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess_세팅 : TriggerState {
            internal StateSuccess_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__MAIN__5$");
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.ResetTimer(timerId: "3");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 2);
                context.SetUserValue(triggerId: 99990004, key: "BossPhase", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSuccess_대사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess_대사용 : TriggerState {
            internal StateSuccess_대사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_smile", duration: 5000, script: "$02020061_BF__MAIN__6$");
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패_세팅 : TriggerState {
            internal State실패_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__MAIN__7$");
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.ResetTimer(timerId: "3");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 2);
                context.SetUserValue(triggerId: 99990004, key: "BossPhase", value: 2);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State실패_대사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패_대사용 : TriggerState {
            internal State실패_대사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020061_BF__MAIN__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FieldWarEnd(isClear: true);
                context.SetAchievement(type: "trigger", code: "FieldwarAchieve_1");
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FieldWarEnd(isClear: false);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
