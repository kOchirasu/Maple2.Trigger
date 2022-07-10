using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020023_bf {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "SpecialTimer", value: 0);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateCamera_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_시작 : TriggerState {
            internal StateCamera_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_캡션(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_캡션 : TriggerState {
            internal StateCamera_캡션(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{501, 502}, returnView: true);
                context.ShowCaption(type: CaptionType.Vertical, title: "$02020023_BF__main__3$", script: "$02020023_BF__main__4$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_줌인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_줌인 : TriggerState {
            internal StateCamera_줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{503, 504}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_블리체Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_블리체Spawn : TriggerState {
            internal StateCamera_블리체Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 505, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_블리체뒤돌기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_블리체뒤돌기 : TriggerState {
            internal StateCamera_블리체뒤돌기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 102, rotation: 180);
                context.AddCinematicTalk(npcId: 23200083, illustId: "Bliche_normal", script: "$02020023_BF__main__1$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_블리체Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_블리체Script1 : TriggerState {
            internal StateCamera_블리체Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 23200083, illustId: "Bliche_normal", script: "$02020023_BF__main__0$", duration: 4000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State블리체_전투시작대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블리체_전투시작대사 : TriggerState {
            internal State블리체_전투시작대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 23200083, illustId: "Bliche_normal", script: "$02020023_BF__main__5$", duration: 4000, align: Align.Left);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.1f);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 901, spawnIds: new []{101}) && context.WaitTick(waitTick: 2000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008}, visible: false);
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new State랭크체크대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랭크체크대사 : TriggerState {
            internal State랭크체크대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonFirstUserMissionScore() >= 1500) {
                    context.SideNpcTalk(npcId: 23200083, illust: "Bliche_smile", duration: 5050, script: "$02020023_BF__main__7$", voice: @"ko/Npc/00002064");
                    return new State던전종료_A랭크이상(context);
                }

                if (context.GetDungeonFirstUserMissionScore() < 1500) {
                    context.SideNpcTalk(npcId: 23200083, illust: "Bliche_nomal", duration: 6158, script: "$02020023_BF__main__8$", voice: @"ko/Npc/00002063");
                    return new State던전종료_A랭크미만(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크미만 : TriggerState {
            internal State던전종료_A랭크미만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.DungeonFail();
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
