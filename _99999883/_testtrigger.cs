using System.Numerics;

namespace Maple2.Trigger._99999883 {
    public static class _testtrigger {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000661, textId: 20000661, duration: 3000);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {100}, itemId: 0)) {
                    context.State = new State07_보상테스트(context);
                    return;
                }

                if (context.GetUserValue(key: "TimeEvent") == 1) {
                    context.State = new State01경험치구슬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State01경험치구슬 : TriggerState {
            internal State01경험치구슬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16});
                context.DebugString(message: "변수를 설정한다");
                context.SetUserValue(key: "TimeEvent", value: 0);
                context.SetUserValue(triggerId: 2, key: "test", value: 1);
                context.GiveExp(arg1: 100, arg2: 36);
            }

            public override void Execute() {
                // 타임이벤트로 유지시간을 받아 끝나면 다시 돌아갑니다.
                if (context.WaitTick(context.GetUserValue(key: "TimeEventLifeTime"))) {
                    context.State = new State컷씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State02업적이벤트 : TriggerState {
            internal State02업적이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "oxquiz_win");
                context.DebugString(message: "업적이벤트테스트");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State컷씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State03컷씬 : TriggerState {
            internal State03컷씬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicIntro(text: @"텍스트 안녕하세요 한줄 \n두줄 테스트 입니다.");
                context.DebugString(message: "컷씬테스트");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State컷씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State04그림자원정대게이지 : TriggerState {
            internal State04그림자원정대게이지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "OpenBossGauge", title: "$02000401_BF__MADRICANSIEGE_Gauge$", maxGaugePoint: 1000);
                context.DebugString(message: "그림자원정대게이지테스트");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State컷씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State05PC이동테스트 : TriggerState {
            internal State05PC이동테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserToPos(pos: new Vector3(907f, 758f, 151f), rot: new Vector3(0f, 0f, 315f));
                context.MoveNpcToPos(spawnPointId: 101, pos: new Vector3(702f, 767f, 151f), rot: new Vector3(0f, 0f, 45f));
                context.DebugString(message: "05PC NPC이동테스트");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State컷씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State06_요일테스트 : TriggerState {
            internal State06_요일테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "06_요일테스트");
            }

            public override void Execute() {
                if (context.DayOfWeek(dayOfWeeks: new byte[] {5}, desc: "1(일)-7(토)")) {
                    context.State = new State03컷씬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State07_보상테스트 : TriggerState {
            internal State07_보상테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "07_보상테스트");
                context.GiveRewardContent(rewardId: 31000003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State컷씬종료 : TriggerState {
            internal State컷씬종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CloseCinematic();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}