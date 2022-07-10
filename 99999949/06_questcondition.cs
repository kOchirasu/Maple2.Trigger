namespace Maple2.Trigger._99999949 {
    public static class _06_questcondition {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{11000064}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9051})) {
                    context.AddEffectNif(spawnId: 11000064, nifPath: @"Map\Royalcity\Indoor\ry_in_cubric_mat_A01.nif", isOutline: true, scale: 0.5f, rotateZ: 45);
                    context.FaceEmotion(emotionName: "Ride_Idle_000");
                    return new StateWait2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "AddEffectNif 테스트");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGuide(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveEffectNif(spawnId: 11000064);
                context.FaceEmotion();
            }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "40002673퀘스트 완료가능 or 완료 상태를 만들고 6번 영역안에 들어가보세요.");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9050}, questIds: new []{40002673, 40002674, 40002675, 40002676, 40002677, 40002678, 40002679}, questStates: new byte[]{1})) {
                    return new StateNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{11000064});
                context.CreateMonster(spawnIds: new []{11000044}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{11000044});
                context.DebugString(message: "5초 후에 트리거가 리셋됩니다. 6번 영역 밖으로 나가세요.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
