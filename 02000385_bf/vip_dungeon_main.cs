using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000385_bf {
    public static class _vip_dungeon_main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
                context.MoveUser(mapId: 02000385, portalId: 1);
                context.SetInteractObject(interactIds: new []{10001083, 10001084, 10001085}, state: 1);
                context.CameraSelect(triggerId: 299, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new State이벤트시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이벤트시작 : TriggerState {
            internal State이벤트시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.CameraSelect(triggerId: 300, enable: true);
                    context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                    return new State캐릭터선택Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State캐릭터선택Wait : TriggerState {
            internal State캐릭터선택Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 20003851, textId: 20003851);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001083}, arg2: 0)) {
                    return new State천둥선택(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001084}, arg2: 0)) {
                    return new State알론선택(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001085}, arg2: 0)) {
                    return new State오스칼선택(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003851);
                context.MoveUser(mapId: 02000385, portalId: 2);
            }
        }

        private class State천둥선택 : TriggerState {
            internal State천둥선택(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.AddBuff(boxIds: new []{199}, skillId: 99910090, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 311, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State게임Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론선택 : TriggerState {
            internal State알론선택(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.AddBuff(boxIds: new []{199}, skillId: 99910100, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 312, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State게임Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼선택 : TriggerState {
            internal State오스칼선택(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.AddBuff(boxIds: new []{199}, skillId: 99910110, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 313, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State게임Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임Prepare : TriggerState {
            internal State게임Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_UI_Start_01");
                context.CreateWidget(type: WidgetType.ScoreBoard);
                context.WidgetAction(type: WidgetType.ScoreBoard, name: "OpenBoard", args: "1");
                context.CameraSelect(triggerId: 301, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.ScoreBoard, name: "SetScore", args: "0"); // 점수 강제 설정
                context.ShowCountUI(text: "$02000385_BF__VIP_DUNGEON_MAIN__0$", stage: 1, count: 3);
                context.SetEventUI(arg1: 0, script: "1,5");
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드시작 : TriggerState {
            internal State1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9991001, key: "round1start", value: 1);
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: false, display: true, arg5: 80);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State1라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드종료 : TriggerState {
            internal State1라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000385_BF__VIP_DUNGEON_MAIN__1$", stage: 2, count: 3);
                context.SetEventUI(arg1: 0, script: "2,5");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드시작 : TriggerState {
            internal State2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9991001, key: "round2start", value: 1);
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: false, display: true, arg5: 80);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State2라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드종료 : TriggerState {
            internal State2라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000385_BF__VIP_DUNGEON_MAIN__2$", stage: 3, count: 3);
                context.SetEventUI(arg1: 0, script: "3,5");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드시작 : TriggerState {
            internal State3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9991001, key: "round3start", value: 1);
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: false, display: true, arg5: 80);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State3라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드종료 : TriggerState {
            internal State3라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000385_BF__VIP_DUNGEON_MAIN__3$", stage: 4, count: 3);
                context.SetEventUI(arg1: 0, script: "4,5");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드시작 : TriggerState {
            internal State4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9991001, key: "round4start", value: 1);
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: false, display: true, arg5: 80);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State4라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드종료 : TriggerState {
            internal State4라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000385_BF__VIP_DUNGEON_MAIN__4$", stage: 5, count: 3);
                context.SetEventUI(arg1: 0, script: "5,5");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드시작 : TriggerState {
            internal State5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9991001, key: "round5start", value: 1);
                context.SetTimer(timerId: "30", seconds: 30, clearAtZero: false, display: true, arg5: 80);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new State게임종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.MoveUser(mapId: 02000385, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State정산(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정산 : TriggerState {
            internal State정산(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{0});
                context.WidgetAction(type: WidgetType.ScoreBoard, name: "CloseBoard");
                context.RemoveBuff(boxId: 199, skillId: 99910090);
                context.RemoveBuff(boxId: 199, skillId: 99910100);
                context.RemoveBuff(boxId: 199, skillId: 99910110);
            }

            public override TriggerState? Execute() {
                // 비교 연산 (연산자,대상값)
                if (context.WidgetCondition(type: WidgetType.ScoreBoard, condition: "Compare", value: ">=,1500")) {
                    context.DebugString(message: "1500점 이상");
                    return new State보상(context);
                }

                // "비교 연산 (연산자,대상값)"
                if (context.WidgetCondition(type: WidgetType.ScoreBoard, condition: "Compare", value: ">=,1000")) {
                    context.DebugString(message: "1000점 이상");
                    return new State보상(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State보상(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상 : TriggerState {
            internal State보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
